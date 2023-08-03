﻿using Application.eTicket.MVC.UseCases.Actor.Responce;
using MediatR;

namespace Application.eTicket.MVC.UseCases.Actor.Queries;
public record GetByIdActorQuery : IRequest<ActorResponce>
{
    public Ulid Id { get; set; }
}

public class GetByIdActorQueryHandler : IRequestHandler<GetByIdActorQuery, ActorResponce>
{
    public Task<ActorResponce> Handle(GetByIdActorQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
