﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.DataAccess.Data;
using WebApp.DataAccess.Repository.IRepository;
using WebApp.Models;

namespace WebApp.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public IApplicationUserRepository ApplicationUser { get; private set; }
        public ICategoryRepository Category { get; private set; }
        public ICompanyRepository Company { get; private set; }
        public IProductRepository Product { get; private set; }
        public IShoppingCartRepository ShoppingCart { get; private set; }
        public IOrderHeaderRepository OrderHeader { get; private set; }
        public IOrderDetailRepository OrderDetail { get; private set; }
        public IProductImageRepository ProductImage { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            ApplicationUser = new ApplicationUserRepository(db);
            Category = new CategoryRepository(db);
            Product = new ProductRepository(db);
            Company = new CompanyRepository(db);
            ShoppingCart = new ShoppingCartRepository(db);
            OrderHeader = new OrderHeaderRepository(db);
            OrderDetail = new OrderDetailRepository(db);
            ProductImage = new ProductImageRepository(db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
