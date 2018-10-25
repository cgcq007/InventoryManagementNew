﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryTest

{
    class ItemContext : DbContext
    {
        public ItemContext() : base("name=InventoryManagement")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ItemContext, InventoryTest.Migrations.Configuration>("InventoryManagement"));

        }
        public DbSet<Item> Items { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ItemDisposed> ItemsDisposed { get; set; }
        public DbSet<ItemBak> ItemBaks { get; set; }

        public DbSet<ItemOutbound> ItemOutbounds { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<ItemBak>();
            base.OnModelCreating(modelBuilder);
        }

    }
}
