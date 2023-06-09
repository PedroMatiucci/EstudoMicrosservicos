﻿// <auto-generated />
using System;
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
    [Migration("20230306193046_relacionamentoBicicletaTranca2")]
    partial class relacionamentoBicicletaTranca2
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

                    b.Property<int>("TrancaId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TrancaId")
                        .IsUnique();

                    b.ToTable("Bicicletas");
                });

            modelBuilder.Entity("scb_equipamentos.Models.Totem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Localizacao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

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

                    b.Property<int>("BicicletaId")
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

                    b.Property<int?>("TotemId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TotemId");

                    b.ToTable("Trancas");
                });

            modelBuilder.Entity("scb_equipamentos.Models.Bicicleta", b =>
                {
                    b.HasOne("scb_equipamentos.Models.Tranca", "Tranca")
                        .WithOne("Bicicleta")
                        .HasForeignKey("scb_equipamentos.Models.Bicicleta", "TrancaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tranca");
                });

            modelBuilder.Entity("scb_equipamentos.Models.Tranca", b =>
                {
                    b.HasOne("scb_equipamentos.Models.Totem", null)
                        .WithMany("Trancas")
                        .HasForeignKey("TotemId");
                });

            modelBuilder.Entity("scb_equipamentos.Models.Totem", b =>
                {
                    b.Navigation("Trancas");
                });

            modelBuilder.Entity("scb_equipamentos.Models.Tranca", b =>
                {
                    b.Navigation("Bicicleta");
                });
#pragma warning restore 612, 618
        }
    }
}
