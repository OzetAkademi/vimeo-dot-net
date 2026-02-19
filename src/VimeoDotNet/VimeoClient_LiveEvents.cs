using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using VimeoDotNet.Constants;
using VimeoDotNet.Models;
using VimeoDotNet.Parameters;

namespace VimeoDotNet
{
    /// <summary>
    /// Class VimeoClient.
    /// Implements the <see cref="VimeoDotNet.IVimeoClient" />
    /// </summary>
    /// <seealso cref="VimeoDotNet.IVimeoClient" />
    public partial class VimeoClient
    {
        /// <summary>
        /// Get live event by ID asynchronously.
        /// </summary>
        /// <param name="liveEventId">The live event identifier.</param>
        /// <param name="fields">JSON filter, as per https://developer.vimeo.com/api/common-formats#json-filter</param>
        /// <returns>A Task&lt;LiveEvent&gt; representing the asynchronous operation.</returns>
        public async Task<LiveEvent> GetLiveEventAsync(long liveEventId, string[] fields = null)
        {
            var request = _apiRequestFactory.AuthorizedRequest(
                AccessToken,
                HttpMethod.Get,
                Endpoints.LiveEvent,
                new Dictionary<string, string>
                {
                    {"liveEventId", liveEventId.ToString()}
                }
            );

            if (fields != null)
            {
                foreach (var field in fields)
                {
                    request.Fields.Add(field);
                }
            }

            return await ExecuteApiRequest<LiveEvent>(request).ConfigureAwait(false);
        }

        /// <summary>
        /// Get live events by user ID asynchronously.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <param name="page">The page number to show.</param>
        /// <param name="perPage">Number of items to show on each page. Max 50.</param>
        /// <param name="fields">JSON filter, as per https://developer.vimeo.com/api/common-formats#json-filter</param>
        /// <returns>A Task&lt;Paginated&lt;LiveEvent&gt;&gt; representing the asynchronous operation.</returns>
        public async Task<Paginated<LiveEvent>> GetLiveEventsAsync(UserId userId, int? page = null, int? perPage = null, string[] fields = null)
        {
            var request = _apiRequestFactory.AuthorizedRequest(
                AccessToken,
                HttpMethod.Get,
                userId.IsMe ? Endpoints.MeLiveEvents : Endpoints.UserLiveEvents,
                new Dictionary<string, string>
                {
                    {"userId", userId.ToString()}
                }
            );

            if (fields != null)
            {
                foreach (var field in fields)
                {
                    request.Fields.Add(field);
                }
            }

            if (page.HasValue)
            {
                request.Query.Add("page", page.ToString());
            }

            if (perPage.HasValue)
            {
                request.Query.Add("per_page", perPage.ToString());
            }

            return await ExecuteApiRequest<Paginated<LiveEvent>>(request).ConfigureAwait(false);
        }

        /// <summary>
        /// Create live event asynchronously.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <param name="parameters">The live event creation parameters.</param>
        /// <returns>A Task&lt;LiveEvent&gt; representing the asynchronous operation.</returns>
        public async Task<LiveEvent> CreateLiveEventAsync(UserId userId, EditLiveEventParameters parameters = null)
        {
            var request = _apiRequestFactory.AuthorizedRequest(
                AccessToken,
                HttpMethod.Post,
                userId.IsMe ? Endpoints.MeLiveEvents : Endpoints.UserLiveEvents,
                new Dictionary<string, string>
                {
                    {"userId", userId.ToString()}
                },
                parameters
            );

            return await ExecuteApiRequest<LiveEvent>(request).ConfigureAwait(false);
        }

        /// <summary>
        /// Update live event asynchronously.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <param name="liveEventId">The live event identifier.</param>
        /// <param name="parameters">The live event update parameters.</param>
        /// <returns>A Task&lt;LiveEvent&gt; representing the asynchronous operation.</returns>
        public async Task<LiveEvent> UpdateLiveEventAsync(UserId userId, long liveEventId, EditLiveEventParameters parameters = null)
        {
            var request = _apiRequestFactory.AuthorizedRequest(
                AccessToken,
                new HttpMethod("PATCH"),
                userId.IsMe ? Endpoints.MeLiveEvent : Endpoints.UserLiveEvent,
                new Dictionary<string, string>
                {
                    {"userId", userId.ToString()},
                    {"liveEventId", liveEventId.ToString()}
                },
                parameters
            );

            return await ExecuteApiRequest<LiveEvent>(request).ConfigureAwait(false);
        }

        /// <summary>
        /// Delete live event asynchronously.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <param name="liveEventId">The live event identifier.</param>
        /// <returns>A Task&lt;bool&gt; representing the asynchronous operation.</returns>
        public async Task<bool> DeleteLiveEventAsync(UserId userId, long liveEventId)
        {
            var request = _apiRequestFactory.AuthorizedRequest(
                AccessToken,
                HttpMethod.Delete,
                userId.IsMe ? Endpoints.MeLiveEvent : Endpoints.UserLiveEvent,
                new Dictionary<string, string>
                {
                    {"userId", userId.ToString()},
                    {"liveEventId", liveEventId.ToString()}
                }
            );

            return await ExecuteApiRequest(request).ConfigureAwait(false);
        }

        /// <summary>
        /// Activate live event asynchronously.
        /// </summary>
        /// <param name="liveEventId">The live event identifier.</param>
        /// <returns>A Task&lt;LiveEvent&gt; representing the asynchronous operation.</returns>
        public async Task<LiveEvent> ActivateLiveEventAsync(long liveEventId)
        {
            var request = _apiRequestFactory.AuthorizedRequest(
                AccessToken,
                HttpMethod.Post,
                Endpoints.LiveEventActivate,
                new Dictionary<string, string>
                {
                    {"liveEventId", liveEventId.ToString()}
                }
            );

            return await ExecuteApiRequest<LiveEvent>(request).ConfigureAwait(false);
        }

        /// <summary>
        /// End live event asynchronously.
        /// </summary>
        /// <param name="liveEventId">The live event identifier.</param>
        /// <returns>A Task&lt;LiveEvent&gt; representing the asynchronous operation.</returns>
        public async Task<LiveEvent> EndLiveEventAsync(long liveEventId)
        {
            var request = _apiRequestFactory.AuthorizedRequest(
                AccessToken,
                HttpMethod.Post,
                Endpoints.LiveEventEnd,
                new Dictionary<string, string>
                {
                    {"liveEventId", liveEventId.ToString()}
                }
            );

            return await ExecuteApiRequest<LiveEvent>(request).ConfigureAwait(false);
        }

        /// <summary>
        /// Get live event videos asynchronously.
        /// </summary>
        /// <param name="liveEventId">The live event identifier.</param>
        /// <param name="page">The page number to show.</param>
        /// <param name="perPage">Number of items to show on each page. Max 50.</param>
        /// <param name="fields">JSON filter, as per https://developer.vimeo.com/api/common-formats#json-filter</param>
        /// <returns>A Task&lt;Paginated&lt;Video&gt;&gt; representing the asynchronous operation.</returns>
        public async Task<Paginated<Video>> GetLiveEventVideosAsync(long liveEventId, int? page = null, int? perPage = null, string[] fields = null)
        {
            var request = _apiRequestFactory.AuthorizedRequest(
                AccessToken,
                HttpMethod.Get,
                Endpoints.LiveEventVideos,
                new Dictionary<string, string>
                {
                    {"liveEventId", liveEventId.ToString()}
                }
            );

            if (fields != null)
            {
                foreach (var field in fields)
                {
                    request.Fields.Add(field);
                }
            }

            if (page.HasValue)
            {
                request.Query.Add("page", page.ToString());
            }

            if (perPage.HasValue)
            {
                request.Query.Add("per_page", perPage.ToString());
            }

            return await ExecuteApiRequest<Paginated<Video>>(request).ConfigureAwait(false);
        }

        /// <summary>
        /// Get live event M3U8 playback URL asynchronously.
        /// </summary>
        /// <param name="liveEventId">The live event identifier.</param>
        /// <returns>A Task&lt;LiveEventM3U8Playback&gt; representing the asynchronous operation, containing the M3U8 playback URL.</returns>
        /// <remarks>
        /// This method retrieves the M3U8 playlist URL for the specified live event.
        /// The M3U8 format is used for HTTP Live Streaming (HLS) playback.
        /// For more information, see: https://developer.vimeo.com/api/reference/live#get_live_event_m3u8_playback
        /// </remarks>
        public async Task<LiveEventM3U8Playback> GetLiveEventM3U8PlaybackAsync(long liveEventId)
        {
            var request = _apiRequestFactory.AuthorizedRequest(
                AccessToken,
                HttpMethod.Get,
                Endpoints.MeLiveEventM3U8Playback,
                new Dictionary<string, string>
                {
                    {"liveEventId", liveEventId.ToString()}
                }
            );

            return await ExecuteApiRequest<LiveEventM3U8Playback>(request).ConfigureAwait(false);
        }

        /// <summary>
        /// Toggle RLE (Reduced Latency Encoding) low latency mode for a live event asynchronously.
        /// </summary>
        /// <param name="liveEventId">The live event identifier.</param>
        /// <param name="enable">True to enable RLE low latency mode; false to disable.</param>
        /// <returns>A Task&lt;LiveEvent&gt; representing the asynchronous operation.</returns>
        /// <remarks>
        /// This method toggles the RLE low latency mode for the specified live event.
        /// RLE low latency mode reduces the latency of the live stream for better real-time interaction.
        /// For more information, see: https://developer.vimeo.com/api/reference/live#toggle_rle_low_latency
        /// </remarks>
        public async Task<LiveEvent> ToggleRleLowLatencyAsync(long liveEventId, bool enable)
        {
            var parameters = new ParameterDictionary
            {
                {"rle_low_latency", enable.ToString().ToLower()}
            };

            var request = _apiRequestFactory.AuthorizedRequest(
                AccessToken,
                new HttpMethod("PATCH"),
                Endpoints.LiveEventToggleRleLowLatency,
                new Dictionary<string, string>
                {
                    {"liveEventId", liveEventId.ToString()}
                },
                parameters
            );

            return await ExecuteApiRequest<LiveEvent>(request).ConfigureAwait(false);
        }

        /// <summary>
        /// Set live event whitelist domains asynchronously.
        /// </summary>
        /// <param name="liveEventId">The live event identifier.</param>
        /// <param name="domains">The list of domains to whitelist for embedding the live event.</param>
        /// <returns>A Task&lt;LiveEvent&gt; representing the asynchronous operation.</returns>
        /// <remarks>
        /// This method sets the domain-level privacy settings for a live event, allowing you to specify which domains are permitted to embed the event.
        /// The live event must have embed privacy set to whitelist for this to work.
        /// For more information, see: https://developer.vimeo.com/api/reference/live#set_live_event_whitelist
        /// </remarks>
        public async Task<LiveEvent> SetLiveEventWhitelistAsync(long liveEventId, string[] domains)
        {
            if (domains == null)
            {
                throw new System.ArgumentNullException(nameof(domains), "Domains list cannot be null.");
            }

            var parameters = new ParameterDictionary
            {
                {"domains", string.Join(",", domains)}
            };

            var request = _apiRequestFactory.AuthorizedRequest(
                AccessToken,
                new HttpMethod("PATCH"),
                Endpoints.LiveEventPrivacyDomains,
                new Dictionary<string, string>
                {
                    {"liveEventId", liveEventId.ToString()}
                },
                parameters
            );

            return await ExecuteApiRequest<LiveEvent>(request).ConfigureAwait(false);
        }
    }
}
