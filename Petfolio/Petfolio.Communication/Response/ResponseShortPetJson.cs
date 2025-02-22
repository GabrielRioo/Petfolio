using Petfolio.Communication.Enum;

namespace Petfolio.Communication.Response;

public class ResponseShortPetJson
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public EPetType Type { get; set; }
}
