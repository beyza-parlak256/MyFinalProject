using Core.DataAcces;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    // Interface Product Data Access Layer anlamına gelir - Veri tabanında yapılacak operasyonları içerir
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
    }
}

// Code Refactoring