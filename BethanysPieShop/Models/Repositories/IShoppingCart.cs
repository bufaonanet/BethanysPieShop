﻿using BethanysPieShop.Models.Entities;

namespace BethanysPieShop.Models.Repositories;

public interface IShoppingCart
{
    void AddToCart(Pie pie);
    int RemoveFromCart(Pie pie);
    List<ShoppingCartItem> GetShoppingCartItems();
    void ClearCart();
    decimal GetShoppingCartTotal();
    List<ShoppingCartItem> ShoppingCartItems { get; set; }
}
