using System;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace VimeoDotNet.Models;

/// <summary>
/// Video live information
/// </summary>
public class VideoLive
{
    /// <summary>
    /// Gets or sets the identifier.
    /// </summary>
    /// <value>The identifier.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "id")]
    public long Id { get; set; }

    /// <summary>
    /// Gets or sets the link.
    /// </summary>
    /// <value>The link.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "link")]
    [CanBeNull]
    public string Link { get; set; }

    /// <summary>
    /// Gets or sets the RTMPS link.
    /// </summary>
    /// <value>The RTMPS link.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "rtmps_link")]
    [CanBeNull]
    public string RtmpsLink { get; set; }

    /// <summary>
    /// Gets or sets the key.
    /// </summary>
    /// <value>The key.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "key")]
    [CanBeNull]
    public string Key { get; set; }

    /// <summary>
    /// Gets or sets the created time.
    /// </summary>
    /// <value>The created time.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "created_time")]
    [CanBeNull]
    public DateTime? CreatedTime { get; set; }

    /// <summary>
    /// Gets or sets the active time.
    /// </summary>
    /// <value>The active time.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "active_time")]
    [CanBeNull]
    public DateTime? ActiveTime { get; set; }

    /// <summary>
    /// Gets or sets the ended time.
    /// </summary>
    /// <value>The ended time.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "ended_time")]
    [CanBeNull]
    public DateTime? EndedTime { get; set; }

    /// <summary>
    /// Gets or sets the archived time.
    /// </summary>
    /// <value>The archived time.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "archived_time")]
    [CanBeNull]
    public DateTime? ArchivedTime { get; set; }

    /// <summary>
    /// Gets or sets the status.
    /// </summary>
    /// <value>The status.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "status")]
    [CanBeNull]
    public string Status { get; set; }

    /// <summary>
    /// Gets or sets the scheduled start time.
    /// </summary>
    /// <value>The scheduled start time.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "scheduled_start_time")]
    [CanBeNull]
    public DateTime? ScheduledStartTime { get; set; }

    /// <summary>
    /// Gets or sets the seconds remaining.
    /// </summary>
    /// <value>The seconds remaining.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "seconds_remaining")]
    public long? SecondsRemaining { get; set; }

    /// <summary>
    /// Gets or sets the session identifier.
    /// </summary>
    /// <value>The session identifier.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "session_id")]
    [CanBeNull]
    public string SessionId { get; set; }

    /// <summary>
    /// Gets or sets the RTMP preview.
    /// </summary>
    /// <value>The RTMP preview.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "rtmp_preview")]
    public int RtmpPreview { get; set; }

    /// <summary>
    /// Gets or sets the recurring event.
    /// </summary>
    /// <value>The recurring event.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "recurring_event")]
    [CanBeNull]
    public VideoLiveRecurringEvent RecurringEvent { get; set; }

    /// <summary>
    /// Gets or sets the chat.
    /// </summary>
    /// <value>The chat.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "chat")]
    [CanBeNull]
    public VideoLiveChat Chat { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this is record mode.
    /// </summary>
    /// <value><c>true</c> if this is record mode; otherwise, <c>false</c>.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "is_record_mode")]
    public bool IsRecordMode { get; set; }
}

