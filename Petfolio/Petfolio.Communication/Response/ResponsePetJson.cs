using Petfolio.Communication.Enum;

namespace Petfolio.Communication.Response;

public class ResponsePetJson
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime Birthday { get; set; }
    public EPetType Type { get; set; }
}
