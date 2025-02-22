using Petfolio.Communication.Request;
using Petfolio.Communication.Response;

namespace Petfolio.Aplication.UseCases.Pets.Register;

public class RegisterPetUseCase
{
    public ResponseRegisterPetJson Execute(RequestPetJson request)
    {
        return new ResponseRegisterPetJson
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
        };
    }
}
