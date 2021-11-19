using Microsoft.EntityFrameworkCore;
using PhotoVoir.Domain.Entities.Orders;
using PhotoVoir.Domain.Entities.Products;
using PhotoVoir.Domain.Entities.Users;
using PhotoVoir.Domain.Entities.Users.Customer;
using PhotoVoir.Domain.Entities.Users.Photographer;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoVoir.Domain.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Photographer> Photographer { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> OrderHistory { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<OrderStatus> OrderStatus { get; set; }
        public DbSet<ShippingAddress> ShippingAddress {get;set;}
    }
}
