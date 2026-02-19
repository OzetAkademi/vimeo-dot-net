using System.Collections.Generic;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace VimeoDotNet.Models;

/// <summary>
/// Video live embed settings
/// </summary>
public class VideoLiveEmbed
{
    /// <summary>
    /// Gets or sets the logos.
    /// </summary>
    /// <value>The logos.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "logos")]
    [CanBeNull]
    public VideoLiveEmbedLogos Logos { get; set; }

    /// <summary>
    /// Gets or sets the color.
    /// </summary>
    /// <value>The color.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "color")]
    [CanBeNull]
    public string Color { get; set; }

    /// <summary>
    /// Gets or sets the colors.
    /// </summary>
    /// <value>The colors.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "colors")]
    [CanBeNull]
    public VideoLiveEmbedColors Colors { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to use color.
    /// </summary>
    /// <value><c>true</c> if color should be used; otherwise, <c>false</c>.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "use_color")]
    public bool UseColor { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether playlist is enabled.
    /// </summary>
    /// <value><c>true</c> if playlist is enabled; otherwise, <c>false</c>.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "playlist")]
    public bool Playlist { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether schedule is enabled.
    /// </summary>
    /// <value><c>true</c> if schedule is enabled; otherwise, <c>false</c>.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "schedule")]
    public bool Schedule { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether autoplay is enabled.
    /// </summary>
    /// <value><c>true</c> if autoplay is enabled; otherwise, <c>false</c>.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "autoplay")]
    public bool Autoplay { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether loop is enabled.
    /// </summary>
    /// <value><c>true</c> if loop is enabled; otherwise, <c>false</c>.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "loop")]
    public bool Loop { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether playbar is shown.
    /// </summary>
    /// <value><c>true</c> if playbar is shown; otherwise, <c>false</c>.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "playbar")]
    public bool Playbar { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether volume control is shown.
    /// </summary>
    /// <value><c>true</c> if volume control is shown; otherwise, <c>false</c>.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "volume")]
    public bool Volume { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether fullscreen button is shown.
    /// </summary>
    /// <value><c>true</c> if fullscreen button is shown; otherwise, <c>false</c>.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "fullscreen_button")]
    public bool FullscreenButton { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether like button is shown.
    /// </summary>
    /// <value><c>true</c> if like button is shown; otherwise, <c>false</c>.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "like_button")]
    public bool LikeButton { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether title is shown.
    /// </summary>
    /// <value><c>true</c> if title is shown; otherwise, <c>false</c>.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "title")]
    public bool Title { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to show latest archived clip.
    /// </summary>
    /// <value><c>true</c> if latest archived clip should be shown; otherwise, <c>false</c>.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "show_latest_archived_clip")]
    public bool ShowLatestArchivedClip { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether event schedule is shown.
    /// </summary>
    /// <value><c>true</c> if event schedule is shown; otherwise, <c>false</c>.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "event_schedule")]
    public bool EventSchedule { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether byline is shown.
    /// </summary>
    /// <value><c>true</c> if byline is shown; otherwise, <c>false</c>.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "byline")]
    public bool Byline { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether portrait is shown.
    /// </summary>
    /// <value><c>true</c> if portrait is shown; otherwise, <c>false</c>.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "portrait")]
    public bool Portrait { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether viewer count is hidden.
    /// </summary>
    /// <value><c>true</c> if viewer count is hidden; otherwise, <c>false</c>.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "hide_viewer_count")]
    public bool HideViewerCount { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether live label is hidden.
    /// </summary>
    /// <value><c>true</c> if live label is hidden; otherwise, <c>false</c>.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "hide_live_label")]
    public bool HideLiveLabel { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether picture-in-picture is enabled.
    /// </summary>
    /// <value><c>true</c> if picture-in-picture is enabled; otherwise, <c>false</c>.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "pip")]
    public bool Pip { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether timezone is shown.
    /// </summary>
    /// <value><c>true</c> if timezone is shown; otherwise, <c>false</c>.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "show_timezone")]
    public bool ShowTimezone { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether AirPlay is enabled.
    /// </summary>
    /// <value><c>true</c> if AirPlay is enabled; otherwise, <c>false</c>.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "airplay")]
    public bool Airplay { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether Chromecast is enabled.
    /// </summary>
    /// <value><c>true</c> if Chromecast is enabled; otherwise, <c>false</c>.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "chromecast")]
    public bool Chromecast { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether transcript is enabled.
    /// </summary>
    /// <value><c>true</c> if transcript is enabled; otherwise, <c>false</c>.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "transcript")]
    public bool Transcript { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether closed captions are enabled.
    /// </summary>
    /// <value><c>true</c> if closed captions are enabled; otherwise, <c>false</c>.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "closed_captions")]
    public bool ClosedCaptions { get; set; }

    /// <summary>
    /// Gets or sets the play button position.
    /// </summary>
    /// <value>The play button position.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "play_button_position")]
    public int PlayButtonPosition { get; set; }

    /// <summary>
    /// Gets or sets the HTML embed code.
    /// </summary>
    /// <value>The HTML embed code.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "html")]
    [CanBeNull]
    public string Html { get; set; }

    /// <summary>
    /// Gets or sets the responsive HTML embed code.
    /// </summary>
    /// <value>The responsive HTML embed code.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "responsive_html")]
    [CanBeNull]
    public string ResponsiveHtml { get; set; }

    /// <summary>
    /// Gets or sets the embed properties.
    /// </summary>
    /// <value>The embed properties.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "embed_properties")]
    [CanBeNull]
    public VideoLiveEmbedProperties EmbedProperties { get; set; }

    /// <summary>
    /// Gets or sets the available player logos.
    /// </summary>
    /// <value>The available player logos.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "available_player_logos")]
    [CanBeNull]
    public List<VideoLiveEmbedPlayerLogo> AvailablePlayerLogos { get; set; }

    /// <summary>
    /// Gets or sets the chat embed code.
    /// </summary>
    /// <value>The chat embed code.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "chat_embed_code")]
    [CanBeNull]
    public string ChatEmbedCode { get; set; }

    /// <summary>
    /// Gets or sets the chat embed source.
    /// </summary>
    /// <value>The chat embed source.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "chat_embed_source")]
    [CanBeNull]
    public string ChatEmbedSource { get; set; }
}

/// <summary>
/// Video live embed properties
/// </summary>
public class VideoLiveEmbedProperties
{
    /// <summary>
    /// Gets or sets the height.
    /// </summary>
    /// <value>The height.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "height")]
    public int Height { get; set; }

    /// <summary>
    /// Gets or sets the width.
    /// </summary>
    /// <value>The width.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "width")]
    public int Width { get; set; }

    /// <summary>
    /// Gets or sets the source URL.
    /// </summary>
    /// <value>The source URL.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "source_url")]
    [CanBeNull]
    public string SourceUrl { get; set; }
}

/// <summary>
/// Video live embed player logo
/// </summary>
public class VideoLiveEmbedPlayerLogo
{
    /// <summary>
    /// Gets or sets the identifier.
    /// </summary>
    /// <value>The identifier.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "id")]
    public long Id { get; set; }

    /// <summary>
    /// Gets or sets the URL.
    /// </summary>
    /// <value>The URL.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "url")]
    [CanBeNull]
    public string Url { get; set; }
}

