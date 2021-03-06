﻿// <auto-generated />
using System;
using ManagmentRR.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ManagmentRR.Migrations
{
    [DbContext(typeof(ManagmentRRContext))]
    [Migration("20190322184708_TrocaTape")]
    partial class TrocaTape
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ManagmentRR.Models.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("ManagmentRR.Models.Tape", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data");

                    b.Property<int>("EmpresaId");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Tape");
                });

            modelBuilder.Entity("ManagmentRR.Models.TrocaTape", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataFim");

                    b.Property<DateTime>("DataInicio");

                    b.Property<int?>("EmpresaId");

                    b.Property<int?>("TapeId");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("TapeId");

                    b.ToTable("TrocaTape");
                });

            modelBuilder.Entity("ManagmentRR.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AdminPriv");

                    b.Property<string>("Nome");

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ManagmentRR.Models.Tape", b =>
                {
                    b.HasOne("ManagmentRR.Models.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ManagmentRR.Models.TrocaTape", b =>
                {
                    b.HasOne("ManagmentRR.Models.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId");

                    b.HasOne("ManagmentRR.Models.Tape", "Tape")
                        .WithMany()
                        .HasForeignKey("TapeId");
                });
#pragma warning restore 612, 618
        }
    }
}
