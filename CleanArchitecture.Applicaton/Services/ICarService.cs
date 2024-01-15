using CleanArchitecture.Applicaton.Features.CarFeatures.Commands.CreateCar;

namespace CleanArchitecture.Applicaton.Services;
public interface ICarService
{
    Task CreateAsync(CreateCarCommand request, CancellationToken cancellationToken);
}
