using BookStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class BookStoreContext : DbContext
    {
        public DbSet<Autor>Autors { get; set; }
        public DbSet<BookModel>Books { get; set; }
        public DbSet<Order>Orders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                @"Server=::1;Port=5433;Databese=BookStore;User Id=postgres;Password=shomi1310");
        }
    }
}
