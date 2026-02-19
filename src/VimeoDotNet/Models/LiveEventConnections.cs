using JetBrains.Annotations;
using Newtonsoft.Json;

namespace VimeoDotNet.Models
{
    /// <summary>
    /// Live event connections
    /// </summary>
    public class LiveEventConnections
    {
        /// <summary>
        /// Gets or sets the pictures.
        /// </summary>
        /// <value>The pictures.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "pictures")]
        [CanBeNull]
        public LiveEventConnectionsEntry Pictures { get; set; }

        /// <summary>
        /// Gets or sets the videos.
        /// </summary>
        /// <value>The videos.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "videos")]
        [CanBeNull]
        public LiveEventConnectionsEntry Videos { get; set; }

        /// <summary>
        /// Gets or sets the live video.
        /// </summary>
        /// <value>The live video.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "live_video")]
        [CanBeNull]
        public LiveEventConnectionsEntry LiveVideo { get; set; }

        /// <summary>
        /// Gets or sets the pre live video.
        /// </summary>
        /// <value>The pre live video.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "pre_live_video")]
        [CanBeNull]
        public VideoLiveRecurringEventPreLiveVideo PreLiveVideo { get; set; }

        /// <summary>
        /// Gets or sets the team member.
        /// </summary>
        /// <value>The team member.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "team_member")]
        [CanBeNull]
        public LiveEventConnectionsEntry TeamMember { get; set; }

        /// <summary>
        /// Gets or sets the team members.
        /// </summary>
        /// <value>The team members.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "team_members")]
        [CanBeNull]
        public LiveEventConnectionsEntry TeamMembers { get; set; }
    }
}

