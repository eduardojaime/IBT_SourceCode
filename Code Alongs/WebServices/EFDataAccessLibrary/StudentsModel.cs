using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EFDataAccessLibrary
{
    public partial class StudentsModel : DbContext
    {
        public StudentsModel()
            : base("name=StudentsModel")
        {
        }

        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.EmailAddr)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Country)
                .IsUnicode(false);
        }
    }
}
