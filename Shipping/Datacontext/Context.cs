using Microsoft.CodeAnalysis;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Shipping.Data
{
    public class Context : DbContext
    {
        // Configuration Constructor 

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        public DbSet<Models.Customer> Customer { get; set; }
        public DbSet<Models.Craditcarrd> Craditcarrds { get; set; }
        public DbSet<Models.Items> Items { get; set; }
        public DbSet<Models.Order> Order { get; set; }
        public DbSet<Models.Product> Product { get; set; }
        public DbSet<Models.O_I> O_I { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.O_I>()


                .HasKey(en => new { en.O_ID, en.I_ID });




            modelBuilder.Entity<Models.O_I>()
                .HasOne(en => en.Order_Order)
                .WithMany(b => b.Itemslist)
                .HasForeignKey(en => en.O_ID);




            modelBuilder.Entity<Models.O_I>()
                .HasOne(en => en.Items_Items)
                .WithMany(b => b.Orderlist)
                .HasForeignKey(en => en.I_ID);
        }
    }
}



