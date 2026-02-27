using VimeoDotNet.Enums;

namespace VimeoDotNet.Parameters;

/// <summary>
/// The type of stream delay on the viewer side.
/// </summary>
public enum LiveEventLatency
{
    /// <summary>
    /// Low latency, with a delay of 5-7 seconds.
    /// </summary>
    [ParameterValue("low")]
    Low,

    /// <summary>
    /// Standard latency, with a delay of 15-20 seconds.
    /// </summary>
    [ParameterValue("standard")]
    Standard,

    /// <summary>
    /// Fail-safe latency, with a delay of 60-75 seconds.
    /// </summary>
    [ParameterValue("fail-safe")]
    FailSafe
}
