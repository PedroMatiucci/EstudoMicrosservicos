﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using scb_equipamentos.Db;

#nullable disable

namespace scb_equipamentos.Migrations
{
    [DbContext(typeof(EquipamentoContext))]
    [Migration("20230301155930_enumerado")]
    partial class enumerado
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("scb_equipamentos.Models.Bicicleta", b =>
                {
                    b.Property<int>("Numero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Numero"));

                    b.Property<int>("AnoFabricacao")
                        .HasColumnType("integer");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TextoStatus")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Status");

                    b.HasKey("Numero");

                    b.ToTable("Bicicletas");
                });
#pragma warning restore 612, 618
        }
    }
}
