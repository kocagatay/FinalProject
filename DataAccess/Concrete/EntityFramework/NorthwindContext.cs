using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context: Db tabloları ile proje classlarını bağlamak
    public class NorthwindContext : DbContext
    {
        //veritabı ile kendi class'larımızı ilişkilendirdiğimiz class'tır
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
        }

        //Benim nesnelerimi db'deki şu nesneyle bağla demek için
        public DbSet<Product> Products { get; set; } //Product nesnemi Products'a bağla.
        public DbSet<Category> Categories { get; set; } // Category nesnemi Categories'e bağla.
        public DbSet<Customer> Customers { get; set; } // Customer nesnemi Customers'a bağla.
        public DbSet<Order> Orders { get; set; } // Order nesnemi Orders'a bağla.
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }


    }
}
