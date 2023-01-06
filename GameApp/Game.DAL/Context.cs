
using Microsoft.EntityFrameworkCore;
using Game.Entities;
using Microsoft.Extensions.Configuration;

namespace Game.DAL
{
    public class Context : DbContext
    {
        public IConfiguration Config;

        /// Jeu de données qui contient les Jeux vidéos et les Commentaires, "point d'entrée" vers leurs tables. 
        public DbSet<VideoGame> VideoGame { get; set; }
        public DbSet<Comment> Comment { get; set; }

        public DbSet<Plateform> plateform { get; set; }
        /*
        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }*/

        // CONSTRUCTEUR : 
        public Context(IConfiguration config)
        {
            Config = config;
        }


        // FLUENT API :
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VideoGame>()
                .Property(g => g.Id)
                .HasColumnName("gameId")
                .IsRequired();

            modelBuilder.Entity<Comment>()
                .Property(c => c.Id)
                .HasColumnName("commentId")
                .IsRequired();

            modelBuilder.Entity<Plateform>()
                .Property(p => p.Id)
                .HasColumnName("plateformId")
                .IsRequired();
        }

        // Connection BDD
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Config.GetConnectionString("GameDB"));
        }
    }
}
