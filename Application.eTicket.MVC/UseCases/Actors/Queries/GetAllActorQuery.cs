﻿using Application.eTicket.MVC.UseCases.Actors.Responce;
using MediatR;

namespace Application.eTicket.MVC.UseCases.Actors.Queries;
public record GetAllActorQuery : IRequest<List<ActorResponce>>;

public class GetAllActorQueryHandler : IRequestHandler<GetAllActorQuery, List<ActorResponce>>
{
    public Task<List<ActorResponce>> Handle(GetAllActorQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
