using Microsoft.EntityFrameworkCore;
using WebApi.Entities;

namespace WebApi
{
    public class DarvinDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Verification> Verifications { get; set; }
        public DbSet<Authentication> Authentications { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<HistoryData> HistoryDatas { get; set; }
        public DbSet<CurrencyPair> CurrencyPairs { get; set; }

        public DarvinDbContext(DbContextOptions<DarvinDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne<Verification>(u => u.Verification)
                .WithOne(v => v.User)
                .HasForeignKey<Verification>(v => v.UserId);

            modelBuilder.Entity<User>()
                .HasOne<Authentication>(u => u.Authentication)
                .WithOne(a => a.User)
                .HasForeignKey<Authentication>(a => a.UserId);

            modelBuilder.Entity<User>()
                .HasMany<Subscription>(u => u.Subscriptions)
                .WithOne(s => s.User)
                .HasForeignKey(s => s.UserId);

            modelBuilder.Entity<Model>()
                .HasOne<HistoryData>(m => m.HistoryData)
                .WithOne(h => h.Model)
                .HasForeignKey<Model>(m => m.HistoryDataId);

            modelBuilder.Entity<CurrencyPair>()
                .HasMany<HistoryData>(cp => cp.HistoryDatas)
                .WithOne(hd => hd.CurrencyPair)
                .HasForeignKey(hd => hd.CurrencyPairId);


            base.OnModelCreating(modelBuilder);
        }
    }
}