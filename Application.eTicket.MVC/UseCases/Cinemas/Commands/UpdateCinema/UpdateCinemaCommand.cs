﻿using Application.eTicket.MVC.UseCases.Cinemas.Responce;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Application.eTicket.MVC.UseCases.Cinemas.Commands;
public record UpdateCinemaCommand : IRequest
{
    public Ulid Id { get; set; }
    public string CinemaName { get; set; }
    public string CinemaDescription { get; set; }
    public IFormFile CinemaLogo { get; set; }
    public string CinemaLocation { get; set; }
}

public class UpdateCinemaCommandHandler : IRequestHandler<UpdateCinemaCommand>
{
    public Task Handle(UpdateCinemaCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
