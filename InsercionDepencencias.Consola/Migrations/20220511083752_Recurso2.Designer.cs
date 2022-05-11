﻿// <auto-generated />
using InsercionDepencencias.Consola;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InsercionDepencencias.Consola.Migrations
{
    [DbContext(typeof(MDBContext))]
    [Migration("20220511083752_Recurso2")]
    partial class Recurso2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("InsercionDepencencias.Consola.Entidades.Recurso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Denominacion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Recursos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Denominacion = "Video_1"
                        },
                        new
                        {
                            Id = 2,
                            Denominacion = "Video_2"
                        },
                        new
                        {
                            Id = 3,
                            Denominacion = "Imagen_1"
                        },
                        new
                        {
                            Id = 4,
                            Denominacion = "Imagen_2"
                        },
                        new
                        {
                            Id = 5,
                            Denominacion = "HTML5_1"
                        },
                        new
                        {
                            Id = 6,
                            Denominacion = "HTML5_2"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
