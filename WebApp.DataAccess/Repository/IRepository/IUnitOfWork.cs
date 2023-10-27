using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IApplicationUserRepository ApplicationUser { get; }
        ICategoryRepository Category { get; }
        ICompanyRepository Company { get; }
        IProductRepository Product { get; }
        IShoppingCartRepository ShoppingCart { get; }
        IOrderHeaderRepository OrderHeader { get; }
        IOrderDetailRepository OrderDetail { get; }
        IProductImageRepository ProductImage { get; }

        void Save();
    }
}
