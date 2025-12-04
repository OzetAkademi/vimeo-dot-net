using JetBrains.Annotations;
using Newtonsoft.Json;

namespace VimeoDotNet.Models
{
    /// <summary>
    /// Live event metadata
    /// </summary>
    public class LiveEventMetadata
    {
        /// <summary>
        /// Gets or sets the connections.
        /// </summary>
        /// <value>The connections.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "connections")]
        public LiveEventConnections Connections { get; set; }

        /// <summary>
        /// Gets or sets the interactions.
        /// </summary>
        /// <value>The interactions.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "interactions")]
        public LiveEventInteractions Interactions { get; set; }
    }
}

