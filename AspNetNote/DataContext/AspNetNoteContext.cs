using AspNetNote.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetNote.DataContext
{

    public class AspNetNoteContext : DbContext
    {

        public DbSet<User> Users { get; set; }

        public DbSet<Note> Notes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=desktop-kcmjh94\sqlexpress;Database=AspNetNoteDb;User Id=sa;
Password=1234;");
        }
    }
}
