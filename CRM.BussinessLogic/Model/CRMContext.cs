﻿using System.Data.Entity;

namespace CRM.BusinessLogic.Model
{
    public class CRMContext : DbContext
    {
        public CRMContext() : base("CRMConnection") { }

        public DbSet<Check> Checks { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sell> Sells { get; set; }
        public DbSet<Seller> Sellers { get; set; }
    }
}
