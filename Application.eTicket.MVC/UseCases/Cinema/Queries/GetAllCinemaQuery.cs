﻿using Application.eTicket.MVC.UseCases.Cinema.Responce;
using MediatR;

namespace Application.eTicket.MVC.UseCases.Cinema.Queries;
public record GetAllCinemaQuery : IRequest<List<CinemaResponce>>;

public class GetAllCinemaQueryHandler : IRequestHandler<GetAllCinemaQuery, List<CinemaResponce>>
{
    public Task<List<CinemaResponce>> Handle(GetAllCinemaQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
