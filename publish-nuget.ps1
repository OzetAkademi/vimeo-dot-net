# PowerShell script to publish VimeoDotNet NuGet package
# This script will:
# 1. Increment the version in the .csproj file
# 2. Build the project in Release mode
# 3. Push the package to NuGet feed
# Usage: .\publish-nuget.ps1 [-SkipVersionIncrement] [-SkipBuild] [-SkipPush]

param(
    [switch]$SkipVersionIncrement = $false,
    [switch]$SkipBuild = $false,
    [switch]$SkipPush = $false,
    [string]$Configuration = "Release"
)

# NuGet feed configuration
$NuGetFeedUrl = "https://azurefhnet/Tuzes.Net/Tuzes6.Git/_packaging/TuzesPackageFeed/nuget/v3/index.json"
$ApiKey = "x"

# Project file path
$projectFile = "src\VimeoDotNet\VimeoDotNet.csproj"

# Function to increment version
function Increment-Version {
    param([string]$Version)
    
    if ([string]::IsNullOrWhiteSpace($Version)) {
        throw "Version string is empty or null"
    }
    
    # Parse version (e.g., "1.0.17")
    $versionParts = $Version.Split('.')
    
    if ($versionParts.Length -lt 3) {
        throw "Version format must be Major.Minor.Patch (e.g., 1.0.17)"
    }
    
    # Increment the last digit (patch version)
    $patchVersion = [int]$versionParts[2]
    $patchVersion++
    $versionParts[2] = $patchVersion.ToString()
    
    # Reconstruct version string
    $newVersion = $versionParts -join '.'
    
    return $newVersion
}

# Function to update version in .csproj file
function Update-ProjectVersion {
    param(
        [string]$ProjectPath,
        [string]$NewVersion
    )
    
    # Resolve to absolute path
    $absolutePath = Resolve-Path $ProjectPath -ErrorAction Stop
    
    if (-not (Test-Path $absolutePath)) {
        throw "Project file not found: $absolutePath"
    }
    
    Write-Host "Reading project file: $absolutePath" -ForegroundColor Cyan
    
    # Load XML document
    [xml]$xmlDoc = Get-Content $absolutePath
    
    # Find Version element in PropertyGroup
    $versionNode = $xmlDoc.Project.PropertyGroup | Where-Object { $_.Version } | Select-Object -First 1
    
    if ($versionNode) {
        $oldVersion = $versionNode.Version
        Write-Host "Updating version: $oldVersion -> $NewVersion" -ForegroundColor Yellow
        
        # Backup original file
        $backupPath = "$absolutePath.backup"
        Copy-Item $absolutePath $backupPath -Force
        Write-Host "Backup created: $backupPath" -ForegroundColor Gray
        
        # Update version
        $versionNode.Version = $NewVersion
        
        # Save XML with proper formatting
        $xmlWriterSettings = New-Object System.Xml.XmlWriterSettings
        $xmlWriterSettings.Indent = $true
        $xmlWriterSettings.IndentChars = "  "
        $xmlWriterSettings.NewLineChars = "`r`n"
        $xmlWriterSettings.NewLineHandling = [System.Xml.NewLineHandling]::Replace
        
        $xmlWriter = [System.Xml.XmlWriter]::Create($absolutePath, $xmlWriterSettings)
        $xmlDoc.Save($xmlWriter)
        $xmlWriter.Close()
        
        Write-Host "Version updated successfully!" -ForegroundColor Green
        return $oldVersion
    }
    else {
        throw "Version tag not found in project file"
    }
}

# Function to get current version from .csproj
function Get-ProjectVersion {
    param([string]$ProjectPath)
    
    if (-not (Test-Path $ProjectPath)) {
        throw "Project file not found: $ProjectPath"
    }
    
    $content = Get-Content $ProjectPath -Raw
    $pattern = '<Version>(\d+\.\d+\.\d+)</Version>'
    
    if ($content -match $pattern) {
        return $matches[1]
    }
    else {
        throw "Version tag not found in project file"
    }
}

# Function to find the nupkg file
function Find-NuGetPackage {
    param([string]$Config)
    
    $searchPaths = @(
        "src\VimeoDotNet\bin\$Config\*.nupkg",
        "bin\$Config\*.nupkg"
    )
    
    foreach ($searchPath in $searchPaths) {
        $found = Get-ChildItem -Path $searchPath -ErrorAction SilentlyContinue | 
                 Sort-Object LastWriteTime -Descending | 
                 Select-Object -First 1
        
        if ($found) {
            return $found.FullName
        }
    }
    
    return $null
}

# Main execution
Write-Host "========================================" -ForegroundColor Cyan
Write-Host "VimeoDotNet NuGet Publish Script" -ForegroundColor Cyan
Write-Host "========================================`n" -ForegroundColor Cyan

try {
    # Step 1: Increment version
    if (-not $SkipVersionIncrement) {
        Write-Host "Step 1: Incrementing version..." -ForegroundColor Yellow
        $currentVersion = Get-ProjectVersion -ProjectPath $projectFile
        Write-Host "Current version: $currentVersion" -ForegroundColor White
        
        $newVersion = Increment-Version -Version $currentVersion
        $oldVersion = Update-ProjectVersion -ProjectPath $projectFile -NewVersion $newVersion
        Write-Host "Version updated: $oldVersion -> $newVersion`n" -ForegroundColor Green
    }
    else {
        Write-Host "Step 1: Skipping version increment (SkipVersionIncrement flag set)" -ForegroundColor Yellow
        $newVersion = Get-ProjectVersion -ProjectPath $projectFile
        Write-Host "Using current version: $newVersion`n" -ForegroundColor White
    }
    
    # Step 2: Build project
    if (-not $SkipBuild) {
        Write-Host "Step 2: Building project in $Configuration mode..." -ForegroundColor Yellow
        $buildCommand = "dotnet build `"$projectFile`" --configuration $Configuration --no-incremental"
        Write-Host "Executing: $buildCommand" -ForegroundColor Gray
        
        Invoke-Expression $buildCommand
        
        if ($LASTEXITCODE -ne 0) {
            throw "Build failed with exit code: $LASTEXITCODE"
        }
        
        Write-Host "Build completed successfully!`n" -ForegroundColor Green
    }
    else {
        Write-Host "Step 2: Skipping build (SkipBuild flag set)`n" -ForegroundColor Yellow
    }
    
    # Step 3: Find package
    Write-Host "Step 3: Locating NuGet package..." -ForegroundColor Yellow
    $packagePath = Find-NuGetPackage -Config $Configuration
    
    if (-not $packagePath -or -not (Test-Path $packagePath)) {
        throw "NuGet package not found. Expected location: src\VimeoDotNet\bin\$Configuration\*.nupkg"
    }
    
    $package = Get-Item $packagePath
    Write-Host "Package found: $($package.Name)" -ForegroundColor Green
    Write-Host "  FullName: $($package.FullName)" -ForegroundColor White
    Write-Host "  Size: $([math]::Round($package.Length / 1KB, 2)) KB" -ForegroundColor White
    Write-Host "  Last Modified: $($package.LastWriteTime)`n" -ForegroundColor White
    
    # Step 4: Push package
    if (-not $SkipPush) {
        Write-Host "Step 4: Pushing package to NuGet feed..." -ForegroundColor Yellow
        Write-Host "  Feed URL: $NuGetFeedUrl" -ForegroundColor White
        Write-Host "  API Key: $ApiKey" -ForegroundColor White
        Write-Host "  Package: $($package.Name)" -ForegroundColor White
        
        # Confirm before pushing
        Write-Host "`nReady to push package to NuGet feed." -ForegroundColor Cyan
        $confirmation = Read-Host "Do you want to continue? (Y/N)"
        if ($confirmation -ne 'Y' -and $confirmation -ne 'y') {
            Write-Host "Publish cancelled." -ForegroundColor Yellow
            exit 0
        }
        
        $pushCommand = "dotnet nuget push `"$($package.FullName)`" --source `"$NuGetFeedUrl`" --api-key `"$ApiKey`""
        Write-Host "Executing: $pushCommand" -ForegroundColor Gray
        
        Invoke-Expression $pushCommand
        
        if ($LASTEXITCODE -eq 0) {
            Write-Host "`n========================================" -ForegroundColor Green
            Write-Host "Package published successfully!" -ForegroundColor Green
            Write-Host "========================================" -ForegroundColor Green
            Write-Host "Version: $newVersion" -ForegroundColor White
            Write-Host "Package: $($package.Name)" -ForegroundColor White
            Write-Host "Feed: $NuGetFeedUrl" -ForegroundColor White
        }
        else {
            throw "Failed to publish package. Exit code: $LASTEXITCODE"
        }
    }
    else {
        Write-Host "Step 4: Skipping push (SkipPush flag set)" -ForegroundColor Yellow
        Write-Host "Package ready at: $($package.FullName)" -ForegroundColor White
    }
}
catch {
    Write-Host "`n========================================" -ForegroundColor Red
    Write-Host "Error occurred: $_" -ForegroundColor Red
    Write-Host "========================================" -ForegroundColor Red
    
    # Restore backup if version was updated
    if (-not $SkipVersionIncrement -and (Test-Path "$projectFile.backup")) {
        Write-Host "`nRestoring project file from backup..." -ForegroundColor Yellow
        Copy-Item "$projectFile.backup" $projectFile -Force
        Remove-Item "$projectFile.backup" -Force
        Write-Host "Project file restored." -ForegroundColor Green
    }
    
    exit 1
}
finally {
    # Clean up backup file if it exists
    if (Test-Path "$projectFile.backup") {
        Remove-Item "$projectFile.backup" -Force -ErrorAction SilentlyContinue
    }
}

