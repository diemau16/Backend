﻿// <auto-generated />
using Backend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Backend.Migrations
{
    [DbContext(typeof(BackendContext))]
    [Migration("20220529012348_InicializarOb1")]
    partial class InicializarOb1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Backend.Modelo.Estudiante", b =>
                {
                    b.Property<int>("idEstudiante")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idEstudiante"), 1L, 1);

                    b.Property<string>("carrera")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("semestre")
                        .HasColumnType("int");

                    b.HasKey("idEstudiante");

                    b.ToTable("Estudiante");
                });
#pragma warning restore 612, 618
        }
    }
}
