using JetBrains.Annotations;
using Newtonsoft.Json;

namespace VimeoDotNet.Models;

/// <summary>
/// Video live chat
/// </summary>
public class VideoLiveChat
{
    /// <summary>
    /// Gets or sets the room identifier.
    /// </summary>
    /// <value>The room identifier.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "room_id")]
    public long RoomId { get; set; }

    /// <summary>
    /// Gets or sets the token.
    /// </summary>
    /// <value>The token.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "token")]
    [CanBeNull]
    public string Token { get; set; }

    /// <summary>
    /// Gets or sets the user.
    /// </summary>
    /// <value>The user.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "user")]
    [CanBeNull]
    public VideoLiveChatUser User { get; set; }
}

/// <summary>
/// Video live chat user
/// </summary>
public class VideoLiveChatUser
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
    /// Gets or sets the identifier.
    /// </summary>
    /// <value>The identifier.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "id")]
    public long Id { get; set; }

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    /// <value>The name.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "name")]
    [CanBeNull]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the account.
    /// </summary>
    /// <value>The account.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "account")]
    [CanBeNull]
    public string Account { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this user is staff.
    /// </summary>
    /// <value><c>true</c> if this user is staff; otherwise, <c>false</c>.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "is_staff")]
    public bool IsStaff { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this user is creator.
    /// </summary>
    /// <value><c>true</c> if this user is creator; otherwise, <c>false</c>.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "is_creator")]
    public bool IsCreator { get; set; }

    /// <summary>
    /// Gets or sets the pictures.
    /// </summary>
    /// <value>The pictures.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "pictures")]
    [CanBeNull]
    public Pictures Pictures { get; set; }

    /// <summary>
    /// Gets or sets the link.
    /// </summary>
    /// <value>The link.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "link")]
    [CanBeNull]
    public string Link { get; set; }
}

