﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServiceParcela.Entities;

#nullable disable

namespace ServiceParcela.Migrations
{
    [DbContext(typeof(ParcelaContex))]
    partial class ParcelaContexModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ServiceParcela.Entities.DeoParcele", b =>
                {
                    b.Property<Guid>("deoParceleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("idealniDeoParcele")
                        .HasColumnType("int");

                    b.Property<Guid>("parcelaID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("stvarniDeoParcele")
                        .HasColumnType("int");

                    b.HasKey("deoParceleID");

                    b.ToTable("deloviParcele");

                    b.HasData(
                        new
                        {
                            deoParceleID = new Guid("5d5a016a-b9c8-4bcd-9824-eec0106b32a8"),
                            idealniDeoParcele = 40,
                            parcelaID = new Guid("b6194c5f-217a-40a4-99c2-5430096d02db"),
                            stvarniDeoParcele = 60
                        },
                        new
                        {
                            deoParceleID = new Guid("61d33f97-6b7e-4aa6-adc5-c307e0da50c3"),
                            idealniDeoParcele = 55,
                            parcelaID = new Guid("b6194c5f-217a-40a4-99c2-5430096d02db"),
                            stvarniDeoParcele = 45
                        });
                });

            modelBuilder.Entity("ServiceParcela.Entities.KatastarskaOpstina", b =>
                {
                    b.Property<Guid>("katastarskaOpstinaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("nazivKatastarskeOpstine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("katastarskaOpstinaID");

                    b.ToTable("katastarskeOpstine");

                    b.HasData(
                        new
                        {
                            katastarskaOpstinaID = new Guid("b41c324d-a885-46ce-93c6-2cf38df6c679"),
                            nazivKatastarskeOpstine = "Čantavir"
                        },
                        new
                        {
                            katastarskaOpstinaID = new Guid("c4e673a1-b52b-4f09-afe4-2d8cd0612ffa"),
                            nazivKatastarskeOpstine = "Bački Vinogradi"
                        },
                        new
                        {
                            katastarskaOpstinaID = new Guid("807391fc-b3f1-4b69-a6a7-c48d54585387"),
                            nazivKatastarskeOpstine = "Bikovo"
                        },
                        new
                        {
                            katastarskaOpstinaID = new Guid("9514b1b3-0d7a-49ae-80ba-46f9df420083"),
                            nazivKatastarskeOpstine = "Đuđin"
                        },
                        new
                        {
                            katastarskaOpstinaID = new Guid("2a366ea1-1141-4d68-a544-3bbdcfb153ba"),
                            nazivKatastarskeOpstine = "Žednik"
                        },
                        new
                        {
                            katastarskaOpstinaID = new Guid("3c13042d-4c28-470b-b512-b6d1bc2c343e"),
                            nazivKatastarskeOpstine = "Tavankut"
                        },
                        new
                        {
                            katastarskaOpstinaID = new Guid("d351326d-624e-454d-b459-e4b145a2b3c8"),
                            nazivKatastarskeOpstine = "Bajmok"
                        },
                        new
                        {
                            katastarskaOpstinaID = new Guid("954d582c-134f-462e-b634-d4eb99d76369"),
                            nazivKatastarskeOpstine = "Donji Grad"
                        },
                        new
                        {
                            katastarskaOpstinaID = new Guid("1a1de9ad-916b-4b43-adda-d5a1783c4a8d"),
                            nazivKatastarskeOpstine = "Stari Grad"
                        },
                        new
                        {
                            katastarskaOpstinaID = new Guid("5c6c9e3b-ddba-4cf9-ae71-eceed1f41989"),
                            nazivKatastarskeOpstine = "Novi Grad"
                        },
                        new
                        {
                            katastarskaOpstinaID = new Guid("c1ef2536-0329-4cc9-b8a9-307e6a259471"),
                            nazivKatastarskeOpstine = "Palić"
                        });
                });

            modelBuilder.Entity("ServiceParcela.Entities.Klasa", b =>
                {
                    b.Property<Guid>("klasaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("nazivKlase")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("klasaID");

                    b.ToTable("klase");

                    b.HasData(
                        new
                        {
                            klasaID = new Guid("ea46fc42-300c-42bd-85ec-b41864c5bfc8"),
                            nazivKlase = "I"
                        },
                        new
                        {
                            klasaID = new Guid("8b479542-bc13-4b6e-8139-f2dc2c47ae74"),
                            nazivKlase = "II"
                        },
                        new
                        {
                            klasaID = new Guid("14791175-a1d8-4ce1-81ce-ab25bc9af38e"),
                            nazivKlase = "III"
                        },
                        new
                        {
                            klasaID = new Guid("17a15c54-c4d3-40a1-b531-2b142aadb2c8"),
                            nazivKlase = "IV"
                        },
                        new
                        {
                            klasaID = new Guid("8adefb3d-8818-4c27-b6c2-276b4063d619"),
                            nazivKlase = "V"
                        },
                        new
                        {
                            klasaID = new Guid("8ed8e0eb-fae8-4de9-9916-1e7f84625d2c"),
                            nazivKlase = "VI"
                        },
                        new
                        {
                            klasaID = new Guid("459a1c86-2562-4599-a1ce-d5259c4a30db"),
                            nazivKlase = "VII"
                        },
                        new
                        {
                            klasaID = new Guid("50bfacfe-4048-4bfe-ab1f-5beaeb33e01c"),
                            nazivKlase = "VIII"
                        });
                });

            modelBuilder.Entity("ServiceParcela.Entities.Kultura", b =>
                {
                    b.Property<Guid>("kulturaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("nazivKulture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("kulturaID");

                    b.ToTable("kulture");

                    b.HasData(
                        new
                        {
                            kulturaID = new Guid("1af29038-928a-46c1-9bee-3d0532b04dea"),
                            nazivKulture = "Njive"
                        },
                        new
                        {
                            kulturaID = new Guid("42b48292-0521-4caa-bb61-46a8cbdb9d3a"),
                            nazivKulture = "Vrtovi"
                        },
                        new
                        {
                            kulturaID = new Guid("e41f48a3-97a3-4093-b375-0b352b2e3802"),
                            nazivKulture = "Voćnjaci"
                        },
                        new
                        {
                            kulturaID = new Guid("29517569-fd26-48dd-a646-0b52790ca6f2"),
                            nazivKulture = "Vinogradi"
                        },
                        new
                        {
                            kulturaID = new Guid("b846877d-225d-45f6-a926-0a9def92e7f4"),
                            nazivKulture = "Livade"
                        },
                        new
                        {
                            kulturaID = new Guid("0245a22d-684b-4e81-8395-08dfe8c6dac8"),
                            nazivKulture = "Pašnjaci"
                        },
                        new
                        {
                            kulturaID = new Guid("055e4525-4401-455a-b5a7-7080803e9efb"),
                            nazivKulture = "Šume"
                        },
                        new
                        {
                            kulturaID = new Guid("2d4eeed9-0e71-42cb-8da1-1957f470a1ff"),
                            nazivKulture = "Trstici-močvare"
                        });
                });

            modelBuilder.Entity("ServiceParcela.Entities.OblikSvojine", b =>
                {
                    b.Property<Guid>("oblikSvojineID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("nazivOblikaSvojine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("oblikSvojineID");

                    b.ToTable("obliciSvojine");

                    b.HasData(
                        new
                        {
                            oblikSvojineID = new Guid("e174e16d-07ef-43fd-9063-02e6cbc268ca"),
                            nazivOblikaSvojine = "Privatna svojina"
                        },
                        new
                        {
                            oblikSvojineID = new Guid("81878ece-4026-40cb-9cf5-077193071211"),
                            nazivOblikaSvojine = "Državna svojina RS"
                        },
                        new
                        {
                            oblikSvojineID = new Guid("ff6aca81-f31b-406e-b90a-f176882e74e8"),
                            nazivOblikaSvojine = "Državna svojina"
                        },
                        new
                        {
                            oblikSvojineID = new Guid("a828ee07-dac0-44a4-9448-d85a67e4ccf1"),
                            nazivOblikaSvojine = "Društvena svojina"
                        },
                        new
                        {
                            oblikSvojineID = new Guid("235cfc03-763b-4ed2-9353-65a0898d6ab0"),
                            nazivOblikaSvojine = "Zadružna svojina"
                        },
                        new
                        {
                            oblikSvojineID = new Guid("09d1cc19-a993-491e-8bc1-2481f9475a1e"),
                            nazivOblikaSvojine = "Mešovita svojina"
                        },
                        new
                        {
                            oblikSvojineID = new Guid("ac2a129f-03da-4e0c-9ad6-5ab63f13a8b5"),
                            nazivOblikaSvojine = "Drugi oblici"
                        });
                });

            modelBuilder.Entity("ServiceParcela.Entities.Obradivost", b =>
                {
                    b.Property<Guid>("obradivostID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("nazivObradivosti")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("obradivostID");

                    b.ToTable("obradivosti");

                    b.HasData(
                        new
                        {
                            obradivostID = new Guid("e3c5f27b-8757-4026-8131-19c127395922"),
                            nazivObradivosti = "Obradivo"
                        },
                        new
                        {
                            obradivostID = new Guid("70928335-ad90-4a80-b672-99319f915698"),
                            nazivObradivosti = "Ostalo"
                        });
                });

            modelBuilder.Entity("ServiceParcela.Entities.Odvodnjavanje", b =>
                {
                    b.Property<Guid>("odvodnjavanjeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("nazivOdvodnjavanja")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("odvodnjavanjeID");

                    b.ToTable("odvodnjavanja");

                    b.HasData(
                        new
                        {
                            odvodnjavanjeID = new Guid("bfd7815f-b9d8-4032-bfcf-9c400c49bc99"),
                            nazivOdvodnjavanja = "Odvodnjavano"
                        },
                        new
                        {
                            odvodnjavanjeID = new Guid("389eab9c-5869-4745-a838-0b9211c227a3"),
                            nazivOdvodnjavanja = "Ostalo"
                        });
                });

            modelBuilder.Entity("ServiceParcela.Entities.Parcela", b =>
                {
                    b.Property<Guid>("parcelaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("brojListaNepokretnosti")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("brojParcele")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("katastarskaOpstinaID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("klasaID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("klasaStvarnoStanje")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("korisnikParceleID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("kulturaID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("kulturaStvarnoStanje")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("oblikSvojineID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("obradivostID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("obradivostStvarnoStanje")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("odvodnjavanjeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("odvodnjavanjeStvarnoStanje")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("povrsina")
                        .HasColumnType("int");

                    b.Property<Guid>("zasticenaZonaID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("zasticenaZonaStvarnoStanje")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("parcelaID");

                    b.ToTable("parcele");

                    b.HasData(
                        new
                        {
                            parcelaID = new Guid("b6194c5f-217a-40a4-99c2-5430096d02db"),
                            brojListaNepokretnosti = "23",
                            brojParcele = "123",
                            katastarskaOpstinaID = new Guid("b41c324d-a885-46ce-93c6-2cf38df6c679"),
                            klasaID = new Guid("ea46fc42-300c-42bd-85ec-b41864c5bfc8"),
                            klasaStvarnoStanje = "da",
                            korisnikParceleID = new Guid("a182e614-9937-4391-8eaf-32e15e072f7f"),
                            kulturaID = new Guid("1af29038-928a-46c1-9bee-3d0532b04dea"),
                            kulturaStvarnoStanje = "da",
                            oblikSvojineID = new Guid("ac2a129f-03da-4e0c-9ad6-5ab63f13a8b5"),
                            obradivostID = new Guid("e3c5f27b-8757-4026-8131-19c127395922"),
                            obradivostStvarnoStanje = "da",
                            odvodnjavanjeID = new Guid("389eab9c-5869-4745-a838-0b9211c227a3"),
                            odvodnjavanjeStvarnoStanje = "da",
                            povrsina = 1152,
                            zasticenaZonaID = new Guid("9aa1cd9b-6e6c-4a9e-8840-641070ab5246"),
                            zasticenaZonaStvarnoStanje = "da"
                        },
                        new
                        {
                            parcelaID = new Guid("ed20eaf8-65ff-4a29-a564-ad7cfc08f7a2"),
                            brojListaNepokretnosti = "43",
                            brojParcele = "124",
                            katastarskaOpstinaID = new Guid("c4e673a1-b52b-4f09-afe4-2d8cd0612ffa"),
                            klasaID = new Guid("50bfacfe-4048-4bfe-ab1f-5beaeb33e01c"),
                            klasaStvarnoStanje = "da",
                            korisnikParceleID = new Guid("76308391-c1e7-450f-b36c-c289f7562116"),
                            kulturaID = new Guid("42b48292-0521-4caa-bb61-46a8cbdb9d3a"),
                            kulturaStvarnoStanje = "da",
                            oblikSvojineID = new Guid("235cfc03-763b-4ed2-9353-65a0898d6ab0"),
                            obradivostID = new Guid("70928335-ad90-4a80-b672-99319f915698"),
                            obradivostStvarnoStanje = "da",
                            odvodnjavanjeID = new Guid("bfd7815f-b9d8-4032-bfcf-9c400c49bc99"),
                            odvodnjavanjeStvarnoStanje = "da",
                            povrsina = 1362,
                            zasticenaZonaID = new Guid("0ff62375-b94c-4415-9ae0-096bb738b8bc"),
                            zasticenaZonaStvarnoStanje = "da"
                        });
                });

            modelBuilder.Entity("ServiceParcela.Entities.ZasticenaZona", b =>
                {
                    b.Property<Guid>("zasticenaZonaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("nazivZasticeneZone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("zasticenaZonaID");

                    b.ToTable("zasticeneZone");

                    b.HasData(
                        new
                        {
                            zasticenaZonaID = new Guid("0ff62375-b94c-4415-9ae0-096bb738b8bc"),
                            nazivZasticeneZone = "1"
                        },
                        new
                        {
                            zasticenaZonaID = new Guid("ef917114-63cd-43c0-a760-e5657f7581c6"),
                            nazivZasticeneZone = "2"
                        },
                        new
                        {
                            zasticenaZonaID = new Guid("7f2f2e22-6324-4c77-a05e-de203e9d4045"),
                            nazivZasticeneZone = "3"
                        },
                        new
                        {
                            zasticenaZonaID = new Guid("9aa1cd9b-6e6c-4a9e-8840-641070ab5246"),
                            nazivZasticeneZone = "4"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}