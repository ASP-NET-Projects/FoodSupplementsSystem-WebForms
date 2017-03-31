using FoodSupplementsSystem.Data.Models;
using System.Collections.Generic;

namespace FoodSupplementsSystem.Data.Services.Contracts
{
    public interface IBrandsServices
    {
        IEnumerable<Brand> GetAll();

        Brand GetById(int id);

        void UpdateById(int id, Brand updateBrand);

        void DeleteById(int id);

        void Create(Brand brand);
    }
}
