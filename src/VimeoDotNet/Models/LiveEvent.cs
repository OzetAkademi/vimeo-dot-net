using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using JetBrains.Annotations;
using Newtonsoft.Json;
using VimeoDotNet.Helpers;

namespace VimeoDotNet.Models
{
    /// <summary>
    /// Live event model
    /// </summary>
    public class LiveEvent
    {
        /// <summary>
        /// Gets the live event identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public long? Id => ModelHelpers.ParseModelUriId(Uri);

        /// <summary>
        /// Gets or sets the URI.
        /// </summary>
        /// <value>The URI.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the link.
        /// </summary>
        /// <value>The link.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "link")]
        public string Link { get; set; }

        /// <summary>
        /// Gets or sets the stream key.
        /// </summary>
        /// <value>The stream key.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "stream_key")]
        public string StreamKey { get; set; }

        /// <summary>
        /// Gets or sets the stream URI.
        /// </summary>
        /// <value>The stream URI.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "stream_uri")]
        public string StreamUri { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>The status.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the scheduled start time.
        /// </summary>
        /// <value>The scheduled start time.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "scheduled_start_time")]
        public DateTime? ScheduledStartTime { get; set; }

        /// <summary>
        /// Gets or sets the scheduled end time.
        /// </summary>
        /// <value>The scheduled end time.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "scheduled_end_time")]
        public DateTime? ScheduledEndTime { get; set; }

        /// <summary>
        /// Gets or sets the time zone.
        /// </summary>
        /// <value>The time zone.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "time_zone")]
        public string TimeZone { get; set; }

        /// <summary>
        /// Gets or sets the embed.
        /// </summary>
        /// <value>The embed.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "embed")]
        [CanBeNull]
        public VideoLiveEmbed Embed { get; set; }

        /// <summary>
        /// Gets or sets the pictures.
        /// </summary>
        /// <value>The pictures.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "pictures")]
        public Pictures Pictures { get; set; }

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        /// <value>The user.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "user")]
        public User User { get; set; }

        /// <summary>
        /// Gets or sets the metadata.
        /// </summary>
        /// <value>The metadata.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "metadata")]
        public LiveEventMetadata Metadata { get; set; }

        /// <summary>
        /// Gets or sets the resource key.
        /// </summary>
        /// <value>The resource key.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "resource_key")]
        public string ResourceKey { get; set; }

        /// <summary>
        /// Gets or sets the created time.
        /// </summary>
        /// <value>The created time.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "created_time")]
        public string CreatedTime { get; set; }

        /// <summary>
        /// Gets or sets the modified time.
        /// </summary>
        /// <value>The modified time.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "modified_time")]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// Gets or sets the live clip.
        /// </summary>
        /// <value>The live clip.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "live_clip")]
        public Video LiveClip { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is RTMP enabled.
        /// </summary>
        /// <value><c>true</c> if this instance is RTMP enabled; otherwise, <c>false</c>.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "rtmp_enabled")]
        public bool? RtmpEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is RTMPS enabled.
        /// </summary>
        /// <value><c>true</c> if this instance is RTMPS enabled; otherwise, <c>false</c>.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "rtmps_enabled")]
        public bool? RtmpsEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance allows DVR.
        /// </summary>
        /// <value><c>true</c> if this instance allows DVR; otherwise, <c>false</c>.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "dvr")]
        public bool? Dvr { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance allows low latency.
        /// </summary>
        /// <value><c>true</c> if this instance allows low latency; otherwise, <c>false</c>.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "low_latency")]
        public bool? LowLatency { get; set; }

        /// <summary>
        /// Gets or sets the content rating.
        /// </summary>
        /// <value>The content rating.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "content_rating")]
        public string[] ContentRating { get; set; }

        /// <summary>
        /// Gets or sets the privacy.
        /// </summary>
        /// <value>The privacy.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "privacy")]
        public Privacy Privacy { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>The password.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the playlist sort.
        /// </summary>
        /// <value>The playlist sort.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "playlist_sort")]
        public string PlaylistSort { get; set; }

        /// <summary>
        /// Gets or sets the live destination.
        /// </summary>
        /// <value>The live destination.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "live_destination")]
        public string LiveDestination { get; set; }

        /// <summary>
        /// Gets or sets the live title.
        /// </summary>
        /// <value>The live title.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "live_title")]
        public string LiveTitle { get; set; }

        /// <summary>
        /// Gets or sets the live slug.
        /// </summary>
        /// <value>The live slug.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "live_slug")]
        public string LiveSlug { get; set; }

        /// <summary>
        /// Gets or sets the live embed code.
        /// </summary>
        /// <value>The live embed code.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "live_embed_code")]
        public string LiveEmbedCode { get; set; }

        /// <summary>
        /// Gets or sets the live embed allowed domains.
        /// </summary>
        /// <value>The live embed allowed domains.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "live_embed_allowed_domains")]
        public string[] LiveEmbedAllowedDomains { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance allows chat.
        /// </summary>
        /// <value><c>true</c> if this instance allows chat; otherwise, <c>false</c>.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "chat_enabled")]
        public bool? ChatEnabled { get; set; }

        /// <summary>
        /// Gets or sets the chat embed code.
        /// </summary>
        /// <value>The chat embed code.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "chat_embed_code")]
        public string ChatEmbedCode { get; set; }

        /// <summary>
        /// Gets or sets the chat room ID.
        /// </summary>
        /// <value>The chat room ID.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "chat_room_id")]
        public string ChatRoomId { get; set; }

        /// <summary>
        /// Gets or sets the chat moderator room ID.
        /// </summary>
        /// <value>The chat moderator room ID.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "chat_moderator_room_id")]
        public string ChatModeratorRoomId { get; set; }

        /// <summary>
        /// Gets or sets the chat embed allowed domains.
        /// </summary>
        /// <value>The chat embed allowed domains.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "chat_embed_allowed_domains")]
        public string[] ChatEmbedAllowedDomains { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance allows automated closed captions.
        /// </summary>
        /// <value><c>true</c> if this instance allows automated closed captions; otherwise, <c>false</c>.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "automated_closed_captions")]
        public bool? AutomatedClosedCaptions { get; set; }

        /// <summary>
        /// Gets or sets the automated closed captions language.
        /// </summary>
        /// <value>The automated closed captions language.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "automated_closed_captions_language")]
        [CanBeNull]
        public string AutomatedClosedCaptionsLanguage { get; set; }

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
        public Video StreamableClip { get; set; }

        /// <summary>
        /// Gets or sets the clip to play.
        /// </summary>
        /// <value>The clip to play.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "clip_to_play")]
        [CanBeNull]
        public Video ClipToPlay { get; set; }

        /// <summary>
        /// Gets or sets the next occurrence time.
        /// </summary>
        /// <value>The next occurrence time.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "next_occurrence_time")]
        [CanBeNull]
        public DateTime? NextOccurrenceTime { get; set; }

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
}

