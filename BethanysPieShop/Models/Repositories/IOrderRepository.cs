using BethanysPieShop.Models.Entities;

namespace BethanysPieShop.Models.Repositories;

public interface IOrderRepository
{
    void CreateOrder(Order order);
}