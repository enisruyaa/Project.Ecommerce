﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project.CONF.Configurations;
using Project.DAL.Extentions;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.ContextClasses
{
    public class MyContext : IdentityDbContext<AppUser,IdentityRole<int>,int>
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new AppUserConfiguration());
            builder.ApplyConfiguration(new AppUserProfileConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new OrderConfiguration());
            builder.ApplyConfiguration(new OrderDetailConfiguration());
            builder.ApplyConfiguration(new ProductConfiguration());
            builder.ApplyConfiguration(new ShipperConfiguration());
            builder.ApplyConfiguration(new SubjectConfiguration());
            builder.ApplyConfiguration(new TicketConfiguration());
            builder.ApplyConfiguration(new CompaignConfiguration());
            builder.ApplyConfiguration(new ProductCompaignConfiguration());
            CategoryDataSeedExtensions.SeedCategories(builder);
            ProductDataSeedExtensions.SeedProducts(builder);
            UserRoleDataSeedExtensions.SeedUsers(builder);
        }

        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<AppUserProfile> Profiles { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Shipper> Shippers { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<Ticket> Tickets { get; set; }

        public DbSet<Campaign> Compaigns { get; set; }

        public DbSet<ProductCompaign> ProductCompaigns { get; set; }

    }
}
