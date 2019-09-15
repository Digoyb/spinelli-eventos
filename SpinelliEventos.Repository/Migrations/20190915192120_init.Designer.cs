﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SpinelliEventos.Repository.data;

namespace SpinelliEventos.Repository.Migrations
{
    [DbContext(typeof(SpinelliEventosContext))]
    [Migration("20190915192120_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SpinelliEventos.Domain.Evento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataEvento");

                    b.Property<string>("Email");

                    b.Property<string>("ImagemURL");

                    b.Property<string>("Local");

                    b.Property<int>("QtdPessoas");

                    b.Property<string>("Telefone");

                    b.Property<string>("Tema");

                    b.HasKey("Id");

                    b.ToTable("Eventos");
                });

            modelBuilder.Entity("SpinelliEventos.Domain.Lote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DataFim");

                    b.Property<DateTime?>("DataInicio");

                    b.Property<int>("EventoId");

                    b.Property<string>("Nome");

                    b.Property<string>("Preco");

                    b.Property<int>("quantidade");

                    b.HasKey("Id");

                    b.HasIndex("EventoId");

                    b.ToTable("Lotes");
                });

            modelBuilder.Entity("SpinelliEventos.Domain.Palestrante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("MiniCurriculo");

                    b.Property<string>("Nome");

                    b.Property<string>("Telefone");

                    b.Property<string>("imagemURL");

                    b.HasKey("Id");

                    b.ToTable("Palestrantes");
                });

            modelBuilder.Entity("SpinelliEventos.Domain.PalestranteEvento", b =>
                {
                    b.Property<int>("EventoId");

                    b.Property<int>("PalestranteId");

                    b.HasKey("EventoId", "PalestranteId");

                    b.HasIndex("PalestranteId");

                    b.ToTable("PalestranteEventos");
                });

            modelBuilder.Entity("SpinelliEventos.Domain.RedeSocial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EventoId");

                    b.Property<string>("Nome");

                    b.Property<int?>("PalestranteId");

                    b.Property<string>("URL");

                    b.HasKey("Id");

                    b.HasIndex("EventoId");

                    b.HasIndex("PalestranteId");

                    b.ToTable("RedeSociais");
                });

            modelBuilder.Entity("SpinelliEventos.Domain.Lote", b =>
                {
                    b.HasOne("SpinelliEventos.Domain.Evento", "Eventos")
                        .WithMany("Lotes")
                        .HasForeignKey("EventoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SpinelliEventos.Domain.PalestranteEvento", b =>
                {
                    b.HasOne("SpinelliEventos.Domain.Evento", "Evento")
                        .WithMany("PalestranteEventos")
                        .HasForeignKey("EventoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SpinelliEventos.Domain.Palestrante", "Palestrante")
                        .WithMany("PalestranteEventos")
                        .HasForeignKey("PalestranteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SpinelliEventos.Domain.RedeSocial", b =>
                {
                    b.HasOne("SpinelliEventos.Domain.Evento", "Evento")
                        .WithMany("RedesSociais")
                        .HasForeignKey("EventoId");

                    b.HasOne("SpinelliEventos.Domain.Palestrante", "Palestrante")
                        .WithMany("RedesSociais")
                        .HasForeignKey("PalestranteId");
                });
#pragma warning restore 612, 618
        }
    }
}
