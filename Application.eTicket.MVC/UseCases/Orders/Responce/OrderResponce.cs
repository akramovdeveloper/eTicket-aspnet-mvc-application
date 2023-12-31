﻿using Application.eTicket.MVC.UseCases.OrderItems.Responce;

namespace Application.eTicket.MVC.UseCases.Orders.Responce;
public class OrderResponce
{
    public Ulid Id { get; set; }
    public Ulid UserId { get; set; }
    public DateTime OrderDate { get; set; }
    public bool IsPaid { get; set; }
    public ICollection<OrderItemResponce> OrderItems { get; set; }
}
