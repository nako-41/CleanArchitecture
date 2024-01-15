using CleanArchitecture.Domain.Dtos;
using MediatR;

namespace CleanArchitecture.Applicaton.Features.CarFeatures.Commands.CreateCar;
public sealed record CreateCarCommand(string Name,string Model,int EnginePower): IRequest<MessageResponse>;

