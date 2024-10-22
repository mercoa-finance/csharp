using System.Text.Json.Serialization;
using Mercoa.Client.Core;
using OneOf;

#nullable enable

namespace Mercoa.Client;

public record EntityGroupAddEntitiesRequest
{
    /// <summary>
    /// List of entity IDs or foreign IDs to add to the group
    /// </summary>
    [JsonPropertyName("entityIds")]
    public IEnumerable<string> EntityIds { get; set; } = new List<string>();

    /// <summary>
    /// Entity ID / foreign ID of an entity currently in the group to copy users and roles from OR a boolean defining if users should be copied to the new entities.
    ///
    /// If not provided or false, users and roles will not be copied.
    /// If true, users and roles will be copied from the first entity the group.
    /// If a valid ID is provided, users and roles will be copied from the corresponding provided entity in the group.
    ///
    /// Note: If users copied, any preexisting users will be left alone, and users with the same foreign ID will not be copied.
    /// </summary>
    [JsonPropertyName("copyUsersFrom")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<bool, string>>))]
    public OneOf<bool, string>? CopyUsersFrom { get; set; }
}
