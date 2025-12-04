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
        /// Gets or sets the videos.
        /// </summary>
        /// <value>The videos.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "videos")]
        public LiveEventConnectionsEntry Videos { get; set; }

        /// <summary>
        /// Gets or sets the team members.
        /// </summary>
        /// <value>The team members.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "team_members")]
        public LiveEventConnectionsEntry TeamMembers { get; set; }

        /// <summary>
        /// Gets or sets the pictures.
        /// </summary>
        /// <value>The pictures.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "pictures")]
        public LiveEventConnectionsEntry Pictures { get; set; }
    }
}

