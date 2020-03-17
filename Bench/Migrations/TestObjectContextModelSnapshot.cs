﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using bench;

namespace Bench.Migrations
{
    [DbContext(typeof(TestObjectContext))]
    partial class TestObjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("bench.TestObject", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("T1")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("T2")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("T3")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("T4")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("T5")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("T6")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("T7")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("T8")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("T9")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ID");

                    b.ToTable("TestObjects");
                });
#pragma warning restore 612, 618
        }
    }
}