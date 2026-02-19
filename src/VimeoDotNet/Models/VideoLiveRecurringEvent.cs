using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace VimeoDotNet.Models;

/// <summary>
/// Video live recurring event
/// </summary>
public class VideoLiveRecurringEvent
{
    /// <summary>
    /// Gets or sets the URI.
    /// </summary>
    /// <value>The URI.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "uri")]
    [CanBeNull]
    public string Uri { get; set; }

    /// <summary>
    /// Gets or sets the link.
    /// </summary>
    /// <value>The link.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "link")]
    [CanBeNull]
    public string Link { get; set; }

    /// <summary>
    /// Gets or sets the created time.
    /// </summary>
    /// <value>The created time.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "created_time")]
    [CanBeNull]
    public string CreatedTime { get; set; }

    /// <summary>
    /// Gets or sets the title.
    /// </summary>
    /// <value>The title.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "title")]
    [CanBeNull]
    public string Title { get; set; }

    /// <summary>
    /// Gets or sets the event type.
    /// </summary>
    /// <value>The event type.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "event_type")]
    [CanBeNull]
    public string EventType { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to automatically title stream.
    /// </summary>
    /// <value><c>true</c> if stream title should be automatically set; otherwise, <c>false</c>.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "automatically_title_stream")]
    public bool AutomaticallyTitleStream { get; set; }

    /// <summary>
    /// Gets or sets the stream title.
    /// </summary>
    /// <value>The stream title.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "stream_title")]
    [CanBeNull]
    public string StreamTitle { get; set; }

    /// <summary>
    /// Gets or sets the stream description.
    /// </summary>
    /// <value>The stream description.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "stream_description")]
    [CanBeNull]
    public string StreamDescription { get; set; }

    /// <summary>
    /// Gets or sets the RTMP link.
    /// </summary>
    /// <value>The RTMP link.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "rtmp_link")]
    [CanBeNull]
    public string RtmpLink { get; set; }

    /// <summary>
    /// Gets or sets the RTMPS link.
    /// </summary>
    /// <value>The RTMPS link.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "rtmps_link")]
    [CanBeNull]
    public string RtmpsLink { get; set; }

    /// <summary>
    /// Gets or sets the stream key.
    /// </summary>
    /// <value>The stream key.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "stream_key")]
    [CanBeNull]
    public string StreamKey { get; set; }

    /// <summary>
    /// Gets or sets the stream privacy.
    /// </summary>
    /// <value>The stream privacy.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "stream_privacy")]
    [CanBeNull]
    public StreamPrivacy StreamPrivacy { get; set; }

    /// <summary>
    /// Gets or sets the stream password.
    /// </summary>
    /// <value>The stream password.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "stream_password")]
    [CanBeNull]
    public string StreamPassword { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether share link is allowed.
    /// </summary>
    /// <value><c>true</c> if share link is allowed; otherwise, <c>false</c>.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "allow_share_link")]
    public bool AllowShareLink { get; set; }

    /// <summary>
    /// Gets or sets the time zone.
    /// </summary>
    /// <value>The time zone.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "time_zone")]
    [CanBeNull]
    public string TimeZone { get; set; }

    /// <summary>
    /// Gets or sets the playlist sort.
    /// </summary>
    /// <value>The playlist sort.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "playlist_sort")]
    [CanBeNull]
    public string PlaylistSort { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether chat is enabled.
    /// </summary>
    /// <value><c>true</c> if chat is enabled; otherwise, <c>false</c>.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "chat_enabled")]
    public bool ChatEnabled { get; set; }

    /// <summary>
    /// Gets or sets the schedule.
    /// </summary>
    /// <value>The schedule.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "schedule")]
    [CanBeNull]
    public object Schedule { get; set; }

    /// <summary>
    /// Gets or sets the streamable clip.
    /// </summary>
    /// <value>The streamable clip.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "streamable_clip")]
    [CanBeNull]
    public object StreamableClip { get; set; }

    /// <summary>
    /// Gets or sets the clip to play.
    /// </summary>
    /// <value>The clip to play.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "clip_to_play")]
    [CanBeNull]
    public object ClipToPlay { get; set; }

    /// <summary>
    /// Gets or sets the next occurrence time.
    /// </summary>
    /// <value>The next occurrence time.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "next_occurrence_time")]
    [CanBeNull]
    public DateTime? NextOccurrenceTime { get; set; }

    /// <summary>
    /// Gets or sets the metadata.
    /// </summary>
    /// <value>The metadata.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "metadata")]
    [CanBeNull]
    public VideoLiveRecurringEventMetadata Metadata { get; set; }

    /// <summary>
    /// Gets or sets the user.
    /// </summary>
    /// <value>The user.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "user")]
    [CanBeNull]
    public User User { get; set; }

    /// <summary>
    /// Gets or sets the pictures.
    /// </summary>
    /// <value>The pictures.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "pictures")]
    [CanBeNull]
    public Pictures Pictures { get; set; }

    /// <summary>
    /// Gets or sets the embed.
    /// </summary>
    /// <value>The embed.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "embed")]
    [CanBeNull]
    public VideoLiveEmbed Embed { get; set; }

    /// <summary>
    /// Gets or sets the live destinations.
    /// </summary>
    /// <value>The live destinations.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "live_destinations")]
    [CanBeNull]
    public object LiveDestinations { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this is from showcase.
    /// </summary>
    /// <value><c>true</c> if this is from showcase; otherwise, <c>false</c>.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "from_showcase")]
    public bool FromShowcase { get; set; }

    /// <summary>
    /// Gets or sets the album.
    /// </summary>
    /// <value>The album.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "album")]
    [CanBeNull]
    public object Album { get; set; }

    /// <summary>
    /// Gets or sets the live clips.
    /// </summary>
    /// <value>The live clips.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "live_clips")]
    [CanBeNull]
    public List<VideoLiveRecurringEventLiveClip> LiveClips { get; set; }

    /// <summary>
    /// Gets or sets the auto CC enabled value.
    /// </summary>
    /// <value>The auto CC enabled value.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "auto_cc_enabled")]
    public int AutoCcEnabled { get; set; }

    /// <summary>
    /// Gets or sets the auto CC keywords.
    /// </summary>
    /// <value>The auto CC keywords.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "auto_cc_keywords")]
    [CanBeNull]
    public string AutoCcKeywords { get; set; }

    /// <summary>
    /// Gets or sets the auto CC remaining.
    /// </summary>
    /// <value>The auto CC remaining.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "auto_cc_remaining")]
    public long AutoCcRemaining { get; set; }

    /// <summary>
    /// Gets or sets the auto CC language.
    /// </summary>
    /// <value>The auto CC language.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "auto_cc_language")]
    [CanBeNull]
    public string AutoCcLanguage { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether unlimited auto CC is enabled.
    /// </summary>
    /// <value><c>true</c> if unlimited auto CC is enabled; otherwise, <c>false</c>.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "unlimited_auto_cc")]
    public bool UnlimitedAutoCc { get; set; }

    /// <summary>
    /// Gets or sets the from private to me folder.
    /// </summary>
    /// <value>The from private to me folder.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "from_private_to_me_folder")]
    [CanBeNull]
    public object FromPrivateToMeFolder { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this is from webinar.
    /// </summary>
    /// <value><c>true</c> if this is from webinar; otherwise, <c>false</c>.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "from_webinar")]
    public bool FromWebinar { get; set; }

    /// <summary>
    /// Gets or sets the webinar.
    /// </summary>
    /// <value>The webinar.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "webinar")]
    [CanBeNull]
    public object Webinar { get; set; }
}

/// <summary>
/// Video live recurring event live clip
/// </summary>
public class VideoLiveRecurringEventLiveClip
{
    /// <summary>
    /// Gets or sets the clip identifier.
    /// </summary>
    /// <value>The clip identifier.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "clip_id")]
    public long ClipId { get; set; }

    /// <summary>
    /// Gets or sets the streaming on timestamp.
    /// </summary>
    /// <value>The streaming on timestamp.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "streaming_on")]
    public long StreamingOn { get; set; }
}

