using JetBrains.Annotations;
using Newtonsoft.Json;

namespace VimeoDotNet.Models;

/// <summary>
/// Video live recurring event metadata
/// </summary>
public class VideoLiveRecurringEventMetadata
{
    /// <summary>
    /// Gets or sets the connections.
    /// </summary>
    /// <value>The connections.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "connections")]
    [CanBeNull]
    public VideoLiveRecurringEventConnections Connections { get; set; }

    /// <summary>
    /// Gets or sets the interactions.
    /// </summary>
    /// <value>The interactions.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "interactions")]
    [CanBeNull]
    public VideoLiveRecurringEventInteractions Interactions { get; set; }
}

/// <summary>
/// Video live recurring event connections
/// </summary>
public class VideoLiveRecurringEventConnections
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
}

/// <summary>
/// Video live recurring event pre live video
/// </summary>
public class VideoLiveRecurringEventPreLiveVideo
{
    /// <summary>
    /// Gets or sets the URI.
    /// </summary>
    /// <value>The URI.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "uri")]
    [CanBeNull]
    public string Uri { get; set; }

    /// <summary>
    /// Gets or sets the options.
    /// </summary>
    /// <value>The options.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "options")]
    [CanBeNull]
    public string[] Options { get; set; }

    /// <summary>
    /// Gets or sets the status.
    /// </summary>
    /// <value>The status.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "status")]
    [CanBeNull]
    public string Status { get; set; }
}

/// <summary>
/// Video live recurring event interactions
/// </summary>
public class VideoLiveRecurringEventInteractions
{
    /// <summary>
    /// Gets or sets the delete interaction.
    /// </summary>
    /// <value>The delete interaction.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "delete")]
    [CanBeNull]
    public LiveEventInteractionsEntry Delete { get; set; }

    /// <summary>
    /// Gets or sets the edit interaction.
    /// </summary>
    /// <value>The edit interaction.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "edit")]
    [CanBeNull]
    public LiveEventInteractionsEntry Edit { get; set; }

    /// <summary>
    /// Gets or sets the activate interaction.
    /// </summary>
    /// <value>The activate interaction.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "activate")]
    [CanBeNull]
    public LiveEventInteractionsEntry Activate { get; set; }
}

