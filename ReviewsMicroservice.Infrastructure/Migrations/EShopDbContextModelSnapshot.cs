﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReviewsMicroservice.Infrastructure.Data;

#nullable disable

namespace ReviewsMicroservice.Infrastructure.Migrations
{
    [DbContext(typeof(EShopDbContext))]
    partial class EShopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ReviewsMicroservice.ApplicationCore.Entities.Customer_Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Customer_Id")
                        .HasColumnType("int");

                    b.Property<string>("Customer_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Order_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Order_Id")
                        .HasColumnType("int");

                    b.Property<int>("Product_Id")
                        .HasColumnType("int");

                    b.Property<string>("Product_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Rating_Value")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Review_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Customer_Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
