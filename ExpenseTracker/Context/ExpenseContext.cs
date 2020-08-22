using ExpenseTracker.EntityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTracker.Context
{
    public class ExpenseContext:DbContext
    {
        private IConfiguration _configuration;
        public ExpenseContext(IConfiguration configuration)
        {
            _configuration = configuration;

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("ExpenseDB"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Expense>()
                .HasOne<Category>(e=>e.Category)
                .WithOne(c=>c.Expense)
                .HasForeignKey<Category>(c => c.CategoryId);
        }

        public DbSet<Expense> ExpenseSet { get; set; }
        public DbSet<Category> CategorySet { get; set; }
    }
}
