﻿// <auto-generated />
using System;
using JAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("JAPI.Model.Entry", b =>
                {
                    b.Property<int>("EntryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("EntryDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("EntryDescr")
                        .HasColumnType("longtext");

                    b.Property<string>("EntryTitle")
                        .HasColumnType("longtext");

                    b.HasKey("EntryId");

                    b.ToTable("Entries");

                    b.HasData(
                        new
                        {
                            EntryId = 1,
                            EntryDate = new DateTime(1996, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EntryDescr = "Presidente da China morre abrindo caminho para democratização",
                            EntryTitle = "Morte de Xim"
                        },
                        new
                        {
                            EntryId = 2,
                            EntryDate = new DateTime(1998, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EntryDescr = "Uma tempestada se aproxima do litoral",
                            EntryTitle = "Tempestade a Vista"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
