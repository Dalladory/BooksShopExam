using Exam.Data.Data.Model;
using Exam.Data.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Data.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-HS72R4R;Database=BookShop;User Id=DESKTOP-HS72R4R\Admin;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().Property(g => g.Name).HasColumnType("varchar").HasMaxLength(100).IsRequired();

            modelBuilder.Entity<Book>().Property(b => b.Name).HasColumnType("varchar").HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Book>().Property(b => b.Author).HasColumnType("varchar").HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Book>().Property(b => b.PublisherName).HasColumnType("varchar").HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Book>().Property(b => b.Genre).HasColumnType("varchar").HasMaxLength(100).IsRequired();
            
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Genre> Genres { get; set; }

        
    }
}
