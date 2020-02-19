using System;
using System.Collections.Generic;
using System.Text;
using BulkyBook.Models;
using BulkyBook.Models.ViewModels;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface IShoppingCartRepository : IRepository<ShoppingCart>
    {
        void Update(ShoppingCart shoppingCart);
    }
}
