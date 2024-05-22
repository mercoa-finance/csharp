using System.Runtime.Serialization;

namespace Mercoa.Client;

public enum OrderDirection
{
    [EnumMember(Value = "ASC")]
    Asc,

    [EnumMember(Value = "DESC")]
    Desc
}
