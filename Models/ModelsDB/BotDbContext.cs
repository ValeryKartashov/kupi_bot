using Microsoft.EntityFrameworkCore;

namespace KupiCore.Models.ModelsDB
{
    public partial class BotDbContext : DbContext
    {
        public BotDbContext()
        {
        }

        public BotDbContext(DbContextOptions<BotDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<FeedbackUrl> FeedbackUrls { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductCategory> ProductCategories { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-SU2DNI1\\SQLEXPRESS;initial catalog=KupiMama;trusted_connection=true;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FeedbackUrl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FeedbackURLs");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Image).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name).HasMaxLength(255);
            });
        }
    }
}
