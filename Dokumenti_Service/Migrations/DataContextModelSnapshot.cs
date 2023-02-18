﻿// <auto-generated />
using System;
using Dokumenti_Service.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Dokumenti_Service.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Dokumenti_Service.Entities.Dokument.Dokument", b =>
                {
                    b.Property<Guid>("dokumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("datumDokumenta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("datumKreiranjaDokumenta")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("dokumentStatusID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("sablon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("zavodniBroj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("dokumentId");

                    b.ToTable("Dokument");

                    b.HasData(
                        new
                        {
                            dokumentId = new Guid("6a411c13-a195-48f7-8dbd-67596c3975a3"),
                            datumDokumenta = new DateTime(2022, 12, 20, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            datumKreiranjaDokumenta = new DateTime(2022, 10, 11, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            dokumentStatusID = new Guid("c61515cf-2210-4358-bcd7-c900b0d52fa7"),
                            sablon = "7b",
                            zavodniBroj = "1"
                        });
                });

            modelBuilder.Entity("Dokumenti_Service.Entities.Dokument.Status", b =>
                {
                    b.Property<Guid>("statusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("statusID");

                    b.ToTable("Status");

                    b.HasData(
                        new
                        {
                            statusID = new Guid("c61515cf-2210-4358-bcd7-c900b0d52fa7"),
                            status = "aktivan"
                        });
                });

            modelBuilder.Entity("Dokumenti_Service.Entities.Oglas.Oglas", b =>
                {
                    b.Property<Guid>("oglasId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("dokumentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("oglasnaTablaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("tekstOglasa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("oglasId");

                    b.HasIndex("dokumentId");

                    b.HasIndex("oglasnaTablaId");

                    b.ToTable("Oglas");

                    b.HasData(
                        new
                        {
                            oglasId = new Guid("6a411c13-a195-48f7-8dbd-67596c397444"),
                            dokumentId = new Guid("6a411c13-a195-48f7-8dbd-67596c3975a3"),
                            oglasnaTablaId = new Guid("6a411c13-a195-48f7-8dbd-67596c397475"),
                            tekstOglasa = "Javni oglas za davanje u zakup poljoprivrednog zemljišta u državnoj svojini"
                        });
                });

            modelBuilder.Entity("Dokumenti_Service.Entities.Oglas.OglasnaTabla", b =>
                {
                    b.Property<Guid>("oglasnaTablaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BrojOglasneTable")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DatumObjavljivanja")
                        .HasColumnType("datetime2");

                    b.HasKey("oglasnaTablaId");

                    b.ToTable("OglasnaTabla");

                    b.HasData(
                        new
                        {
                            oglasnaTablaId = new Guid("6a411c13-a195-48f7-8dbd-67596c397475"),
                            BrojOglasneTable = 12,
                            DatumObjavljivanja = new DateTime(2020, 11, 15, 9, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Dokumenti_Service.Entities.Oglas.OglasnaTablaOglas", b =>
                {
                    b.Property<Guid>("oglasId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("oglasnaTablaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("oglasId", "oglasnaTablaId");

                    b.HasIndex("oglasnaTablaId");

                    b.ToTable("OglasnaTablaOglas");
                });

            modelBuilder.Entity("Dokumenti_Service.Entities.Zalba.RadnjaNaOsnovuZalbe", b =>
                {
                    b.Property<Guid>("radnjaNaOsnovuZalbeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("radnjaNaOsnovuZalbe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("radnjaNaOsnovuZalbeId");

                    b.ToTable("Radnja");

                    b.HasData(
                        new
                        {
                            radnjaNaOsnovuZalbeId = new Guid("6a411c13-a195-48f7-8dbd-67596c3974c0"),
                            radnjaNaOsnovuZalbe = "JN ide u drugi krug sa novim uslovima"
                        });
                });

            modelBuilder.Entity("Dokumenti_Service.Entities.Zalba.TipZalbe", b =>
                {
                    b.Property<Guid>("tipZalbeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("tipZalbe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("tipZalbeId");

                    b.ToTable("TipZalbe");

                    b.HasData(
                        new
                        {
                            tipZalbeId = new Guid("6a411c13-a195-48f7-8dbd-67596c3974c0"),
                            tipZalbe = "Zalba na tok javnog nadmetanja"
                        },
                        new
                        {
                            tipZalbeId = new Guid("1c7ea607-8ddb-493a-87fa-4bf5893e965b"),
                            tipZalbe = "Zalba na Odluku o davanju u zakup"
                        });
                });

            modelBuilder.Entity("Dokumenti_Service.Entities.Zalba.Zalba", b =>
                {
                    b.Property<Guid>("zalbaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("KupacID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("brojOdluke")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("brojResenja")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("datumPodnosenja")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("dokumentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("obrazlozenje")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("radnjaNaOsnovuZalbeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("razlog")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("statusZalbe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("tipZalbeID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("zalbaId");

                    b.HasIndex("dokumentId");

                    b.HasIndex("radnjaNaOsnovuZalbeId");

                    b.HasIndex("tipZalbeID");

                    b.ToTable("Zalba");

                    b.HasData(
                        new
                        {
                            zalbaId = new Guid("6a411c13-a195-48f7-8dbd-67596c3974c0"),
                            brojOdluke = "27c",
                            brojResenja = "1a",
                            datumPodnosenja = new DateTime(2022, 11, 20, 10, 6, 0, 0, DateTimeKind.Unspecified),
                            obrazlozenje = "Smatramo da dokumenti koje smo predali nisu evidentirani adekvatno",
                            radnjaNaOsnovuZalbeId = new Guid("6a411c13-a195-48f7-8dbd-67596c3974c0"),
                            razlog = "Dokumenti nisu evidentirani validno",
                            statusZalbe = "pregledana",
                            tipZalbeID = new Guid("1c7ea607-8ddb-493a-87fa-4bf5893e965b")
                        });
                });

            modelBuilder.Entity("Dokumenti_Service.Entities.Oglas.Oglas", b =>
                {
                    b.HasOne("Dokumenti_Service.Entities.Dokument.Dokument", "dokument")
                        .WithMany()
                        .HasForeignKey("dokumentId");

                    b.HasOne("Dokumenti_Service.Entities.Oglas.OglasnaTabla", "oglasnaTabla")
                        .WithMany()
                        .HasForeignKey("oglasnaTablaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("dokument");

                    b.Navigation("oglasnaTabla");
                });

            modelBuilder.Entity("Dokumenti_Service.Entities.Oglas.OglasnaTablaOglas", b =>
                {
                    b.HasOne("Dokumenti_Service.Entities.Oglas.Oglas", "Oglas")
                        .WithMany()
                        .HasForeignKey("oglasId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Dokumenti_Service.Entities.Oglas.OglasnaTabla", "OglasnaTabla")
                        .WithMany()
                        .HasForeignKey("oglasnaTablaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Oglas");

                    b.Navigation("OglasnaTabla");
                });

            modelBuilder.Entity("Dokumenti_Service.Entities.Zalba.Zalba", b =>
                {
                    b.HasOne("Dokumenti_Service.Entities.Dokument.Dokument", "dokument")
                        .WithMany()
                        .HasForeignKey("dokumentId");

                    b.HasOne("Dokumenti_Service.Entities.Zalba.RadnjaNaOsnovuZalbe", "radnjaNaOsnovuZalbe")
                        .WithMany()
                        .HasForeignKey("radnjaNaOsnovuZalbeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dokumenti_Service.Entities.Zalba.TipZalbe", "tipZalbe")
                        .WithMany()
                        .HasForeignKey("tipZalbeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("dokument");

                    b.Navigation("radnjaNaOsnovuZalbe");

                    b.Navigation("tipZalbe");
                });
#pragma warning restore 612, 618
        }
    }
}
