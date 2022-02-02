using Exam.Data.Data.Model;
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

        DbSet<Book> Books { get; set; }
        DbSet<Order> Orders { get; set; }

        
    }
}
