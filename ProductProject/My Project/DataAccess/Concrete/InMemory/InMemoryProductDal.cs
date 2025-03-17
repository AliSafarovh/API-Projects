﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
             {
              new Product { ProductId = 1, CategoryId = 1, ProductName = "Tv", UnitPrice = 1550, UnitsInStock = 1500 },
              new Product { ProductId = 2, CategoryId = 1, ProductName = "Smartphone", UnitPrice = 1550, UnitsInStock = 1500 },
              new Product { ProductId = 3, CategoryId = 3, ProductName = "Yataq", UnitPrice = 1550, UnitsInStock = 1500 },
              new Product { ProductId = 4, CategoryId = 2, ProductName = "Tava", UnitPrice = 1550, UnitsInStock = 1500 }
             };
        }

        public Task AddAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetAllAsync(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetAsync(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductDetailDto>> GetProductDetailsAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
