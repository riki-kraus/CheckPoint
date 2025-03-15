using CheckPoint.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint.Data
{
    public class DataContext:DbContext

    {
        public DbSet<User> users { get; set; }
        public DbSet<Exam> exams { get; set; } 
        public DbSet<Result> results { get; set; } 
        public DbSet<Answer> answers { get; set; }

        public DbSet<Student> students { get; set; }
        public DbSet<Manager> managers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=my_db;Trusted_Connection=True");
            // optionsBuilder.LogTo(msg => Debug.WriteLine(msg));



        }

    }
}

