using JetBrains.Annotations;
using Newtonsoft.Json;

namespace VimeoDotNet.Models
{
    /// <summary>
    /// Live event interactions
    /// </summary>
    public class LiveEventInteractions
    {
        /// <summary>
        /// Gets or sets the activate.
        /// </summary>
        /// <value>The activate.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "activate")]
        public LiveEventInteractionsEntry Activate { get; set; }

        /// <summary>
        /// Gets or sets the end.
        /// </summary>
        /// <value>The end.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "end")]
        public LiveEventInteractionsEntry End { get; set; }
    }
}

