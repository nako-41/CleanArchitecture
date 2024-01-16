using AutoMapper;
using CleanArchitecture.Applicaton.Features.CarFeatures.Commands.CreateCar;
using CleanArchitecture.Applicaton.Services;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Persistance.Context;

namespace CleanArchitecture.Persistance.Services;
public sealed class CarService : ICarService
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;

    public CarService(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task CreateAsync(CreateCarCommand request, CancellationToken cancellationToken)
    {
        //Car car = new Car
        //{
        //    Name = request.Name,
        //    Model = request.Model,
        //    EnginePower = request.EnginePower,
        //};

        Car car = _mapper.Map<Car>(request);

        await  _context.Set<Car>().AddAsync(car,cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
    }
}
