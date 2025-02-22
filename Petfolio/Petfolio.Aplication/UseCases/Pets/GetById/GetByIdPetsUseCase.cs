using Petfolio.Communication.Response;

namespace Petfolio.Aplication.UseCases.Pets.GetById;

public class GetByIdPetsUseCase
{
    public ResponsePetJson Execute(Guid id)
    {
        return new ResponsePetJson
        {
            Id = id,
            Name = "Shaya",
            Type = Communication.Enum.EPetType.Cat,
            Birthday = new DateTime(year: 2023, month: 1, day: 1),
        };
    }
}
