using Petfolio.Communication.Response;

namespace Petfolio.Aplication.UseCases.Pets.GetAll;

public class GetAllPetsUseCase
{
    public ResponseAllPetJson Execute()
    {
        return new ResponseAllPetJson
        {
            Pets = new List<ResponseShortPetJson>
            {
                new ResponseShortPetJson
                {
                    Id = Guid.NewGuid(),
                    Name = "Shaya",
                    Type = Communication.Enum.EPetType.Dog
                }
            }
        };
    }
}
