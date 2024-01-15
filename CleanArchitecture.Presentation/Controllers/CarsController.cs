﻿using CleanArchitecture.Applicaton.Features.CarFeatures.Commands.CreateCar;
using CleanArchitecture.Domain.Dtos;
using CleanArchitecture.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Presentation.Controllers;
public class CarsController : ApiController
{
    public CarsController(IMediator mediator) : base(mediator){}


    [HttpPost("[action]")]
    public async Task<IActionResult> Create(CreateCarCommand request,CancellationToken cancellationToken)
    {
       MessageResponse messageResponse= await _mediator.Send(request, cancellationToken);
        return Ok(messageResponse);
    }

}
