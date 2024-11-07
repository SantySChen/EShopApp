﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PromotionsMicroservice.Infrastructure.Data;

#nullable disable

namespace PromotionsMicroservice.Infrastructure.Migrations
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

            modelBuilder.Entity("PromotionsMicroservice.ApplicatonCore.Entities.Promotion_Detail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Product_Category_Id")
                        .HasColumnType("int");

                    b.Property<string>("Product_Category_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Promotion_SaleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Promotion_SaleId");

                    b.ToTable("Promotion_Details");
                });

            modelBuilder.Entity("PromotionsMicroservice.ApplicatonCore.Entities.Promotion_Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("End_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Start_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Promotion_Sales");
                });

            modelBuilder.Entity("PromotionsMicroservice.ApplicatonCore.Entities.Promotion_Detail", b =>
                {
                    b.HasOne("PromotionsMicroservice.ApplicatonCore.Entities.Promotion_Sale", "Promotion_Sale")
                        .WithMany()
                        .HasForeignKey("Promotion_SaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Promotion_Sale");
                });
#pragma warning restore 612, 618
        }
    }
}