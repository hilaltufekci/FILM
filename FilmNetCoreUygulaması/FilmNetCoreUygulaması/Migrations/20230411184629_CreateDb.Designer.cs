﻿// <auto-generated />
using FilmNetCoreUygulaması.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FilmNetCoreUygulaması.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230411184629_CreateDb")]
    partial class CreateDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FilmNetCoreUygulaması.Models.Film", b =>
                {
                    b.Property<int>("FilmNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FilmAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FilmTürü")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("VizyonTarihi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ımbd")
                        .HasColumnType("int");

                    b.HasKey("FilmNo");

                    b.ToTable("Films");
                });

            modelBuilder.Entity("FilmNetCoreUygulaması.Models.Oyuncu", b =>
                {
                    b.Property<int>("OyuncuNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OynadigiFilmSayisi")
                        .HasColumnType("int");

                    b.Property<string>("OyuncuAdi")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("OyuncuSoyadi")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("OyuncuYas")
                        .HasColumnType("int");

                    b.HasKey("OyuncuNo");

                    b.ToTable("Oyuncus");
                });

            modelBuilder.Entity("FilmNetCoreUygulaması.Models.Seyirci", b =>
                {
                    b.Property<int>("SeyirciNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cinsiyet")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("SeyirciAdi")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("SeyirciSoyadi")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Yas")
                        .HasColumnType("int");

                    b.HasKey("SeyirciNo");

                    b.ToTable("Seyircis");
                });

            modelBuilder.Entity("FilmNetCoreUygulaması.Models.Yönetmen", b =>
                {
                    b.Property<int>("YönetmenNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FilmSayisi")
                        .HasColumnType("int");

                    b.Property<int>("Yas")
                        .HasColumnType("int");

                    b.Property<string>("YönetmenAdi")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("YönetmenSoyadi")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("YönetmenNo");

                    b.ToTable("Yönetmens");
                });
#pragma warning restore 612, 618
        }
    }
}
