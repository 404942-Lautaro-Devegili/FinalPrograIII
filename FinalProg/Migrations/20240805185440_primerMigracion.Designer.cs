﻿// <auto-generated />
using System;
using FinalProg.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinalProg.Migrations
{
    [DbContext(typeof(SucursalesContext))]
    [Migration("20240805185440_primerMigracion")]
    partial class primerMigracion
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FinalProg.Models.Configuracion", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Valor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Configuraciones");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0218f171-ae2b-44ab-9440-92b1bf05ab8f"),
                            Nombre = "padding-top",
                            Valor = "50px"
                        },
                        new
                        {
                            Id = new Guid("a0182e62-420e-4941-be49-9b359716c59a"),
                            Nombre = "padding-left",
                            Valor = "100px"
                        });
                });

            modelBuilder.Entity("FinalProg.Models.Provincia", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Provincias");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ad82b082-eb91-4fbb-8218-6fcfac0f91ef"),
                            Nombre = "Buenos Aires"
                        },
                        new
                        {
                            Id = new Guid("39720254-ca8e-4aaf-a70c-b445850e8c23"),
                            Nombre = "Córdoba"
                        },
                        new
                        {
                            Id = new Guid("b9d686f4-4cd2-4382-bdd6-a39803fc31b3"),
                            Nombre = "Salta"
                        });
                });

            modelBuilder.Entity("FinalProg.Models.Sucursal", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ApellidoTitular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("IdProvincia")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdTipo")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreTitular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdProvincia");

                    b.HasIndex("IdTipo");

                    b.ToTable("Sucursales");
                });

            modelBuilder.Entity("FinalProg.Models.TipoSucursal", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TiposSucursal");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f861c32f-8264-483c-b63a-40433baa55de"),
                            Nombre = "Pequeña"
                        },
                        new
                        {
                            Id = new Guid("19154042-35ab-4533-8b3b-7d02f69721e4"),
                            Nombre = "Grande"
                        });
                });

            modelBuilder.Entity("FinalProg.Models.Sucursal", b =>
                {
                    b.HasOne("FinalProg.Models.Provincia", "Provincia")
                        .WithMany("Sucursales")
                        .HasForeignKey("IdProvincia");

                    b.HasOne("FinalProg.Models.TipoSucursal", "TipoSucursal")
                        .WithMany("Sucursales")
                        .HasForeignKey("IdTipo");

                    b.Navigation("Provincia");

                    b.Navigation("TipoSucursal");
                });

            modelBuilder.Entity("FinalProg.Models.Provincia", b =>
                {
                    b.Navigation("Sucursales");
                });

            modelBuilder.Entity("FinalProg.Models.TipoSucursal", b =>
                {
                    b.Navigation("Sucursales");
                });
#pragma warning restore 612, 618
        }
    }
}
