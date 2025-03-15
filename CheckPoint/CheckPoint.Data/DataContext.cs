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
        //public DbSet<User> users { get; set; }
        public DbSet<Exam> Exams { get; set; } 
        public DbSet<Submission> Submissions { get; set; } 
        public DbSet<Answer> Answers { get; set; }

          public DbSet<User> Users { get; set; }
      //  public DbSet<Manager> managers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=my_db;Trusted_Connection=True");
            // optionsBuilder.LogTo(msg => Debug.WriteLine(msg));
      
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // פתרון בעיית ה-Discriminator
            modelBuilder.Entity<User>()
                .HasDiscriminator<string>("Role")
                .HasValue<User>("User")
                .HasValue<Student>("Student")
                .HasValue<Manager>("Management");

        }
    }
}

