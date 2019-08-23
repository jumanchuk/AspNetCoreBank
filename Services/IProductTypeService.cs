using AspNetCoreBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreBank.Services
{
    public interface IProductTypeService
    {
        Task<ProductType[]> GetAll();
    }
}
