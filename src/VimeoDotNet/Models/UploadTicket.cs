using JetBrains.Annotations;
using Newtonsoft.Json;

namespace VimeoDotNet.Models
{
    /// <summary>
    /// Upload ticket
    /// </summary>
    public class UploadTicket : Video
    {

        /// <summary>
        /// Upload status
        /// </summary>
        /// <value>The upload.</value>
        [PublicAPI]
        [JsonProperty(PropertyName = "upload")]
        public ResumableUploadStatus Upload { get; set; }
    }
}
