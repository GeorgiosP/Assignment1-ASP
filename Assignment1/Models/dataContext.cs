namespace Assignment1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class dataContext : DbContext
    {
        public dataContext()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>()
                .HasMany(e => e.Games)
                .WithRequired(e => e.Genre)
                .WillCascadeOnDelete(false);
        }
    }
}
