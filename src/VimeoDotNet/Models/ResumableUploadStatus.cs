using JetBrains.Annotations;
using Newtonsoft.Json;

namespace VimeoDotNet.Models;

/// <summary>
/// Class ResumableUploadStatus.
/// </summary>
public class ResumableUploadStatus
{
    /// <summary>
    /// Upload Approach
    /// </summary>
    /// <value>The approach.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "approach")]
    public string Approach { get; set; }
    /// <summary>
    /// Upload Status
    /// </summary>
    /// <value>The status.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }
    /// <summary>
    /// Upload link
    /// </summary>
    /// <value>The upload link.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "upload_link")]
    public string UploadLink { get; set; }
    /// <summary>
    /// Video Size in bytes
    /// </summary>
    /// <value>The size.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "size")]
    public long Size { get; set; }

}