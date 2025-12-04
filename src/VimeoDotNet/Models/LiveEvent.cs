using System;
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
        public Embed Embed { get; set; }

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
        public string AutomatedClosedCaptionsLanguage { get; set; }
    }
}

