﻿using Application.eTicket.MVC.UseCases.Movies.Responce;
using MediatR;

namespace Application.eTicket.MVC.UseCases.Movies.Queries;
public record GetByIdMovieQuery : IRequest<MovieResponce>
{
    public Ulid Id { get; set; }
}

public class GetByIdMovieQueryHandler : IRequestHandler<GetByIdMovieQuery, MovieResponce>
{
    public Task<MovieResponce> Handle(GetByIdMovieQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}