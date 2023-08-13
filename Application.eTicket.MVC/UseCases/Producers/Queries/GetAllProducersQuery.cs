﻿using Application.eTicket.MVC.UseCases.Producers.Responce;
using MediatR;

namespace Application.eTicket.MVC.UseCases.Producers.Queries;
public record GetAllProducersQuery : IRequest<List<ProducerResponce>>;

public class GetAllProducersQueryHandler : IRequestHandler<GetAllProducersQuery, List<ProducerResponce>>
{
    public Task<List<ProducerResponce>> Handle(GetAllProducersQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
