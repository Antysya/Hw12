﻿using Models;
namespace BlazorWASM.Model
{
    public interface IProductCatalog
    {
        IReadOnlyList<Product> GetProducts();
        Task<Product> GetProductAsync(int productId);
        Task AddProduct(string name, decimal price, Category category, string imageUrl);
    }
}
