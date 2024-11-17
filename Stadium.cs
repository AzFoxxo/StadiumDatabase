/*
 *   Copyright (c) 2024 
 *   All rights reserved.
 */
using Microsoft.EntityFrameworkCore;

namespace StadiumDatabase
{
    class Stadium : DbContext
    {
        public Stadium(DbContextOptions<Stadium> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured) return;
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;");
        }
    }
}