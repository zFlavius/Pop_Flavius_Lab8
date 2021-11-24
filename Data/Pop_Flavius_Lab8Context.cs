using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pop_Flavius_Lab8.Models;

namespace Pop_Flavius_Lab8.Data
{
    public class Pop_Flavius_Lab8Context : DbContext
    {
        public Pop_Flavius_Lab8Context (DbContextOptions<Pop_Flavius_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Pop_Flavius_Lab8.Models.Book> Book { get; set; }

        public DbSet<Pop_Flavius_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Pop_Flavius_Lab8.Models.Category> Category { get; set; }
    }
}
