using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using VimeoDotNet.Enums;

namespace VimeoDotNet.Parameters
{
    /// <summary>
    /// Edit live event parameters
    /// </summary>
    public class EditLiveEventParameters : IParameterProvider
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        [PublicAPI]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        [PublicAPI]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the scheduled start time.
        /// </summary>
        /// <value>The scheduled start time.</value>
        [PublicAPI]
        public DateTime? ScheduledStartTime { get; set; }

        /// <summary>
        /// Gets or sets the scheduled end time.
        /// </summary>
        /// <value>The scheduled end time.</value>
        [PublicAPI]
        public DateTime? ScheduledEndTime { get; set; }

        /// <summary>
        /// Gets or sets the time zone.
        /// </summary>
        /// <value>The time zone.</value>
        [PublicAPI]
        public string TimeZone { get; set; }

        /// <summary>
        /// Gets or sets the privacy.
        /// </summary>
        /// <value>The privacy.</value>
        [PublicAPI]
        [JsonConverter(typeof(StringEnumConverter))]
        public LiveEventPrivacyOption? Privacy { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>The password.</value>
        [PublicAPI]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether RTMP is enabled.
        /// </summary>
        /// <value><c>true</c> if RTMP is enabled; otherwise, <c>false</c>.</value>
        [PublicAPI]
        public bool? RtmpEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether RTMPS is enabled.
        /// </summary>
        /// <value><c>true</c> if RTMPS is enabled; otherwise, <c>false</c>.</value>
        [PublicAPI]
        public bool? RtmpsEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether DVR is enabled.
        /// </summary>
        /// <value><c>true</c> if DVR is enabled; otherwise, <c>false</c>.</value>
        [PublicAPI]
        public bool? Dvr { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether low latency is enabled.
        /// </summary>
        /// <value><c>true</c> if low latency is enabled; otherwise, <c>false</c>.</value>
        [PublicAPI]
        public bool? LowLatency { get; set; }

        /// <summary>
        /// Gets or sets the content rating.
        /// </summary>
        /// <value>The content rating.</value>
        [PublicAPI]
        public List<LiveEventContentRating> ContentRating { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether chat is enabled.
        /// </summary>
        /// <value><c>true</c> if chat is enabled; otherwise, <c>false</c>.</value>
        [PublicAPI]
        public bool? ChatEnabled { get; set; }

        /// <summary>
        /// Gets or sets the chat embed allowed domains.
        /// </summary>
        /// <value>The chat embed allowed domains.</value>
        [PublicAPI]
        public string[] ChatEmbedAllowedDomains { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether automated closed captions are enabled.
        /// </summary>
        /// <value><c>true</c> if automated closed captions are enabled; otherwise, <c>false</c>.</value>
        [PublicAPI]
        public bool? AutomatedClosedCaptions { get; set; }

        /// <summary>
        /// Gets or sets the automated closed captions language.
        /// </summary>
        /// <value>The automated closed captions language.</value>
        [PublicAPI]
        public string AutomatedClosedCaptionsLanguage { get; set; }

        /// <summary>
        /// Gets or sets the live embed allowed domains.
        /// </summary>
        /// <value>The live embed allowed domains.</value>
        [PublicAPI]
        public string[] LiveEmbedAllowedDomains { get; set; }

        /// <inheritdoc />
        public string ValidationError()
        {
            if (Privacy is LiveEventPrivacyOption.Password && string.IsNullOrEmpty(Password))
            {
                return "Password is required if Privacy value is set to Password.";
            }

            return null;
        }

        /// <inheritdoc />
        public IDictionary<string, string> GetParameterValues()
        {
            var parameterValues = new Dictionary<string, string>();

            if (!string.IsNullOrEmpty(Title))
            {
                parameterValues.Add("title", Title);
            }

            if (!string.IsNullOrEmpty(Description))
            {
                parameterValues.Add("stream_title", Description);
            }

            if (ScheduledStartTime.HasValue)
            {
                parameterValues.Add("scheduled_start_time", ScheduledStartTime.Value.ToString("yyyy-MM-ddTHH:mm:ssZ"));
            }

            if (ScheduledEndTime.HasValue)
            {
                parameterValues.Add("scheduled_end_time", ScheduledEndTime.Value.ToString("yyyy-MM-ddTHH:mm:ssZ"));
            }

            if (!string.IsNullOrEmpty(TimeZone))
            {
                parameterValues.Add("time_zone", TimeZone);
            }

            if (Privacy.HasValue)
            {
                parameterValues.Add("privacy", Privacy.Value.GetParameterValue());
            }

            if (!string.IsNullOrEmpty(Password))
            {
                parameterValues.Add("password", Password);
            }

            if (RtmpEnabled.HasValue)
            {
                parameterValues.Add("rtmp_enabled", RtmpEnabled.Value.ToString().ToLower());
            }

            if (RtmpsEnabled.HasValue)
            {
                parameterValues.Add("rtmps_enabled", RtmpsEnabled.Value.ToString().ToLower());
            }

            if (Dvr.HasValue)
            {
                parameterValues.Add("dvr", Dvr.Value.ToString().ToLower());
            }

            if (LowLatency.HasValue)
            {
                parameterValues.Add("low_latency", LowLatency.Value.ToString().ToLower());
            }

            if (ContentRating is { Count: > 0 })
            {
                var contentRatings = new List<string>();
                foreach (var rating in ContentRating)
                {
                    contentRatings.Add(rating.GetParameterValue());
                }
                parameterValues.Add("content_rating", string.Join(",", contentRatings));
            }

            if (ChatEnabled.HasValue)
            {
                parameterValues.Add("chat_enabled", ChatEnabled.Value.ToString().ToLower());
            }

            if (ChatEmbedAllowedDomains is { Length: > 0 })
            {
                parameterValues.Add("chat_embed_allowed_domains", string.Join(",", ChatEmbedAllowedDomains));
            }

            if (AutomatedClosedCaptions.HasValue)
            {
                parameterValues.Add("automated_closed_captions", AutomatedClosedCaptions.Value.ToString().ToLower());
            }

            if (!string.IsNullOrEmpty(AutomatedClosedCaptionsLanguage))
            {
                parameterValues.Add("automated_closed_captions_language", AutomatedClosedCaptionsLanguage);
            }

            if (LiveEmbedAllowedDomains is { Length: > 0 })
            {
                parameterValues.Add("live_embed_allowed_domains", string.Join(",", LiveEmbedAllowedDomains));
            }

            return parameterValues.Keys.Count > 0 ? parameterValues : null;
        }
    }
}

