using Microsoft.EntityFrameworkCore;
using SimpleTrader.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTrader.DAL
{
    public class SimpleTraderDbContext : DbContext
    {
        

        public DbSet<User> Users {get;set;}
        public DbSet<Account> Accounts { get;set;}
        public DbSet<AssetTransaction> AssetTransactions { get;set;}
        
        public SimpleTraderDbContext(DbContextOptions options) : base(options)
        {

        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AssetTransaction>().OwnsOne(x => x.Stock);

            base.OnModelCreating(modelBuilder);
        }

    }
}
