using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Luca_Andra_Lab2._2.Models;

namespace Luca_Andra_Lab2._2.Data
{
    public class Luca_Andra_Lab2_2Context : DbContext
    {
        public Luca_Andra_Lab2_2Context (DbContextOptions<Luca_Andra_Lab2_2Context> options)
            : base(options)
        {
        }

        public DbSet<Luca_Andra_Lab2._2.Models.Book> Book { get; set; } = default!;

        public DbSet<Luca_Andra_Lab2._2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Luca_Andra_Lab2._2.Models.Category>? Category { get; set; }

        public DbSet<Luca_Andra_Lab2._2.Models.Author>? Author { get; set; }
    }
}
