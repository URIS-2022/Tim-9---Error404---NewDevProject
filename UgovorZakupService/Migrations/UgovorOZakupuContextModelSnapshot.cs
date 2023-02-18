﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UgovorZakupService.Entities;

#nullable disable

namespace UgovorZakupService.Migrations
{
    [DbContext(typeof(UgovorOZakupuContext))]
    partial class UgovorOZakupuContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("UgovorZakupService.Entities.TipGarancije", b =>
                {
                    b.Property<Guid>("tipGarancijeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("nazivTipaGarancije")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("tipGarancijeID");

                    b.ToTable("tipoviGarancije");

                    b.HasData(
                        new
                        {
                            tipGarancijeID = new Guid("1ae2154e-70f4-4621-855b-a56df534f019"),
                            nazivTipaGarancije = "Tip 1"
                        },
                        new
                        {
                            tipGarancijeID = new Guid("ca93a3db-f1c3-40c8-92d7-a6ea3790cfed"),
                            nazivTipaGarancije = "Tip 2"
                        });
                });

            modelBuilder.Entity("UgovorZakupService.Entities.UgovorOZakupu", b =>
                {
                    b.Property<Guid>("ugovorOZakupuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("datumPotpisa")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("datumZavodjenja")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("dokumentID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("javnoNadmetanjeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("kupacID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("licnostID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("mestoPotpisivanja")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("rokVracanjeZemljista")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("tipGarancijeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("zavodniBroj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ugovorOZakupuID");

                    b.ToTable("ugovoriOZakupu");

                    b.HasData(
                        new
                        {
                            ugovorOZakupuID = new Guid("77647f87-7ff4-4722-a02b-4d34f3d8836f"),
                            datumPotpisa = new DateTime(2022, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            datumZavodjenja = new DateTime(2022, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            dokumentID = new Guid("566e5f3e-616c-4cce-928f-9a85f12cd856"),
                            javnoNadmetanjeID = new Guid("1e412998-875c-4e53-9845-f853f42f80b2"),
                            kupacID = new Guid("10051eab-b9ac-467a-933b-2c1d82975137"),
                            licnostID = new Guid("a5b356fd-99a2-435b-b3d5-87da7c5f9a7f"),
                            mestoPotpisivanja = "test mesto potpisivanja",
                            rokVracanjeZemljista = new DateTime(2022, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            tipGarancijeID = new Guid("70760f84-4571-4d15-b6c5-bc90a0e83855"),
                            zavodniBroj = "test zavodni broj"
                        },
                        new
                        {
                            ugovorOZakupuID = new Guid("36721eec-7775-4fde-b11e-1bc287b1accd"),
                            datumPotpisa = new DateTime(2022, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            datumZavodjenja = new DateTime(2022, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            dokumentID = new Guid("3b468a72-621e-4f1e-8fa7-da06fd28427c"),
                            javnoNadmetanjeID = new Guid("040f7bb0-8c60-4c11-9fd1-f7a05a9eb7e6"),
                            kupacID = new Guid("b62afc63-812f-4a4d-ba6d-af57fc7c5882"),
                            licnostID = new Guid("088527cf-20d1-4f47-8f57-66b68ded5639"),
                            mestoPotpisivanja = "test mesto potpisivanja",
                            rokVracanjeZemljista = new DateTime(2022, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            tipGarancijeID = new Guid("f21636a8-639a-4922-82f8-40a6c8fab202"),
                            zavodniBroj = "test zavodni broj"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
