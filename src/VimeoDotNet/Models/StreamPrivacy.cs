using System;
using System.Collections.Generic;
using System.Text;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace VimeoDotNet.Models;

public class StreamPrivacy
{
    [PublicAPI]
    [JsonProperty("view")]
    public string View { get; set; }
}
