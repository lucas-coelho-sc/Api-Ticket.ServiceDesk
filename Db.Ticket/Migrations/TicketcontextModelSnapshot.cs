﻿// <auto-generated />
using AtendimentosSD;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EF.AtendimentosSD.Migrations
{
    [DbContext(typeof(Ticketcontext))]
    partial class TicketcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Classes.Atendimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Analista")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Data")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Filial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeDoUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ticket")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Atendimentos");
                });
#pragma warning restore 612, 618
        }
    }
}
