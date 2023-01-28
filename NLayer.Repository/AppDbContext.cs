﻿using Microsoft.EntityFrameworkCore;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository
{   
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<Category>? Categories { get; set; }
        public DbSet<Product>? Products { get; set; }
        public DbSet<ProductFeature>? ProductFeatures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Entity<ProductFeature>().HasData(new ProductFeature
            {
                Id = 1,
                Color = "Red",
                Width = 200,
                Height = 300,
                ProductId = 1

            },
            new ProductFeature
            {
                Id = 2,
                Color = "Blue",
                Width = 300,
                Height = 400,
                ProductId = 2
            }
            );

            //Olusturulacak tablolarin ozelligini belirlemek icin Configurations Klasorunu kullandık   
            base.OnModelCreating(modelBuilder);
        }
    }
}
