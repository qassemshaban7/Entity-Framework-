﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Route_EF_02;

namespace Route_EF_02.Migrations
{
    [DbContext(typeof(UniversityContext))]
    [Migration("20231002122209_TPHWith2DbSet")]
    partial class TPHWith2DbSet
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Route_EF_02.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Person");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("Route_EF_02.Student", b =>
                {
                    b.HasBaseType("Route_EF_02.Person");

                    b.Property<DateTime>("EnrollDate")
                        .HasColumnType("datetime2");

                    b.HasDiscriminator().HasValue("Student");
                });

            modelBuilder.Entity("Route_EF_02.Teacher", b =>
                {
                    b.HasBaseType("Route_EF_02.Person");

                    b.Property<DateTime>("HirDate")
                        .HasColumnType("datetime2");

                    b.HasDiscriminator().HasValue("Teacher");
                });
#pragma warning restore 612, 618
        }
    }
}
