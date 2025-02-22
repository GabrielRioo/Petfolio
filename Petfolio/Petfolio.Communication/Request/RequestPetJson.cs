using Petfolio.Communication.Enum;

namespace Petfolio.Communication.Request;

public class RequestPetJson
{
    public string Name { get; set; } = string.Empty;
    public DateTime Birthday { get; set; }
    public EPetType Type{ get; set; }
}
