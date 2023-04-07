﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using scb_equipamentos.Db;

#nullable disable

namespace scb_equipamentos.Migrations
{
    [DbContext(typeof(EquipamentoContext))]
    partial class EquipamentoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("scb_equipamentos.Models.Bicicleta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AnoFabricacao")
                        .HasColumnType("integer");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Numero")
                        .HasColumnType("integer");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Status");

                    b.HasKey("Id");

                    b.ToTable("Bicicletas");
                });

            modelBuilder.Entity("scb_equipamentos.Models.Totem", b =>
                {
                    b.Property<int>("Numero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Numero"));

                    b.Property<string>("Localizacao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Numero");

                    b.ToTable("Totems");
                });

            modelBuilder.Entity("scb_equipamentos.Models.Tranca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AnoFabricacao")
                        .HasColumnType("integer");

                    b.Property<int?>("BicicletaId")
                        .HasColumnType("integer");

                    b.Property<string>("Localizacao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Numero")
                        .HasColumnType("integer");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Status");

                    b.Property<int?>("TotemNumero")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("BicicletaId")
                        .IsUnique();

                    b.HasIndex("TotemNumero");

                    b.ToTable("Trancas");
                });

            modelBuilder.Entity("scb_equipamentos.Models.Tranca", b =>
                {
                    b.HasOne("scb_equipamentos.Models.Bicicleta", "Bicicleta")
                        .WithOne("Tranca")
                        .HasForeignKey("scb_equipamentos.Models.Tranca", "BicicletaId");

                    b.HasOne("scb_equipamentos.Models.Totem", null)
                        .WithMany("Trancas")
                        .HasForeignKey("TotemNumero");

                    b.Navigation("Bicicleta");
                });

            modelBuilder.Entity("scb_equipamentos.Models.Bicicleta", b =>
                {
                    b.Navigation("Tranca");
                });

            modelBuilder.Entity("scb_equipamentos.Models.Totem", b =>
                {
                    b.Navigation("Trancas");
                });
#pragma warning restore 612, 618
        }
    }
}
