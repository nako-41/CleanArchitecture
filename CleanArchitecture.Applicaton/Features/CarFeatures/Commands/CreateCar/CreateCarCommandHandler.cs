using CleanArchitecture.Applicaton.Services;
using CleanArchitecture.Domain.Dtos;
using MediatR;

namespace CleanArchitecture.Applicaton.Features.CarFeatures.Commands.CreateCar;
public sealed class CreateCarCommandHandler : IRequestHandler<CreateCarCommand, MessageResponse>
{
    private readonly ICarService _carService;

    public CreateCarCommandHandler(ICarService carService)
    {
        _carService = carService;
    }

    public async Task<MessageResponse> Handle(CreateCarCommand request, CancellationToken cancellationToken)
    {
        //throw new NotImplementedException();

        await _carService.CreateAsync(request, cancellationToken);

        return new("arac basarıyla uretildi");
    }
}
