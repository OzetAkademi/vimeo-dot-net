using JetBrains.Annotations;
using Newtonsoft.Json;

namespace VimeoDotNet.Models;

public class StreamPrivacy
{
    [PublicAPI]
    [JsonProperty("view")]
    public string View { get; set; }

    [PublicAPI]
    [JsonProperty("embed")]
    [CanBeNull]
    public string Embed { get; set; }

    [PublicAPI]
    [JsonProperty("unlisted_hash")]
    [CanBeNull]
    public string UnlistedHash { get; set; }
}
