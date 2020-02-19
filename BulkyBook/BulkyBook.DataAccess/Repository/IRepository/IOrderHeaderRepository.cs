using System;
using System.Collections.Generic;
using System.Text;
using BulkyBook.Models;
using BulkyBook.Models.ViewModels;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface IOrderHeaderRepository : IRepository<OrderHeader>
    {
        void Update(OrderHeader orderHeader);
    }
}
