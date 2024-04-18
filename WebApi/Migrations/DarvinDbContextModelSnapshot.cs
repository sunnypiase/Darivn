﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi;

#nullable disable

namespace WebApi.Migrations
{
    [DbContext(typeof(DarvinDbContext))]
    partial class DarvinDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApi.Entities.Authentication", b =>
                {
                    b.Property<int>("AuthenticationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthenticationId"));

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("AuthenticationId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Authentications");
                });

            modelBuilder.Entity("WebApi.Entities.CurrencyPair", b =>
                {
                    b.Property<int>("CurrencyPairId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CurrencyPairId"));

                    b.Property<string>("Base")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Quote")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CurrencyPairId");

                    b.ToTable("CurrencyPairs");
                });

            modelBuilder.Entity("WebApi.Entities.HistoryData", b =>
                {
                    b.Property<int>("HistoryDataId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HistoryDataId"));

                    b.Property<string>("BlobUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CurrencyPairId")
                        .HasColumnType("int");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeFrame")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HistoryDataId");

                    b.HasIndex("CurrencyPairId");

                    b.ToTable("HistoryDatas");
                });

            modelBuilder.Entity("WebApi.Entities.Model", b =>
                {
                    b.Property<int>("ModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ModelId"));

                    b.Property<string>("BlobUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HistoryDataId")
                        .HasColumnType("int");

                    b.HasKey("ModelId");

                    b.HasIndex("HistoryDataId")
                        .IsUnique();

                    b.ToTable("Models");
                });

            modelBuilder.Entity("WebApi.Entities.Subscription", b =>
                {
                    b.Property<int>("SubscriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubscriptionId"));

                    b.Property<bool>("IsTrading")
                        .HasColumnType("bit");

                    b.Property<int>("ModelId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("SubscriptionId");

                    b.HasIndex("ModelId");

                    b.HasIndex("UserId");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("WebApi.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Telegram")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WebApi.Entities.Verification", b =>
                {
                    b.Property<int>("VerificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VerificationId"));

                    b.Property<string>("ApiKeyHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("VerificationId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Verifications");
                });

            modelBuilder.Entity("WebApi.Entities.Authentication", b =>
                {
                    b.HasOne("WebApi.Entities.User", "User")
                        .WithOne("Authentication")
                        .HasForeignKey("WebApi.Entities.Authentication", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApi.Entities.HistoryData", b =>
                {
                    b.HasOne("WebApi.Entities.CurrencyPair", "CurrencyPair")
                        .WithMany("HistoryDatas")
                        .HasForeignKey("CurrencyPairId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CurrencyPair");
                });

            modelBuilder.Entity("WebApi.Entities.Model", b =>
                {
                    b.HasOne("WebApi.Entities.HistoryData", "HistoryData")
                        .WithOne("Model")
                        .HasForeignKey("WebApi.Entities.Model", "HistoryDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HistoryData");
                });

            modelBuilder.Entity("WebApi.Entities.Subscription", b =>
                {
                    b.HasOne("WebApi.Entities.Model", "Model")
                        .WithMany()
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApi.Entities.User", "User")
                        .WithMany("Subscriptions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Model");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApi.Entities.Verification", b =>
                {
                    b.HasOne("WebApi.Entities.User", "User")
                        .WithOne("Verification")
                        .HasForeignKey("WebApi.Entities.Verification", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApi.Entities.CurrencyPair", b =>
                {
                    b.Navigation("HistoryDatas");
                });

            modelBuilder.Entity("WebApi.Entities.HistoryData", b =>
                {
                    b.Navigation("Model")
                        .IsRequired();
                });

            modelBuilder.Entity("WebApi.Entities.User", b =>
                {
                    b.Navigation("Authentication")
                        .IsRequired();

                    b.Navigation("Subscriptions");

                    b.Navigation("Verification")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
