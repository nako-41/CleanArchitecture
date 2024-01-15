using CleanArchitecture.Domain.Dtos;
using MediatR;

namespace CleanArchitecture.Applicaton.Features.CarFeatures.Commands.CreateCar;
public sealed class CreateCarCommandHandler : IRequestHandler<CreateCarCommand, MessageResponse>
{
    public async Task<MessageResponse> Handle(CreateCarCommand request, CancellationToken cancellationToken)
    {
        //throw new NotImplementedException();

        return new("arac basarıyla uretildi");
    }
}
