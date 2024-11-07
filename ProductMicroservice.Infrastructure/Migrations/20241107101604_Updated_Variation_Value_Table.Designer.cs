﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductMicroservice.Infrastructure.Data;

#nullable disable

namespace ProductMicroservice.Infrastructure.Migrations
{
    [DbContext(typeof(EShopDbContext))]
    [Migration("20241107101604_Updated_Variation_Value_Table")]
    partial class Updated_Variation_Value_Table
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProductMicroservice.ApplicationCore.Entities.Category_Variation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Product_CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Variation_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Product_CategoryId");

                    b.ToTable("Category_Variations");
                });

            modelBuilder.Entity("ProductMicroservice.ApplicationCore.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Product_CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Product_Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Qty")
                        .HasColumnType("int");

                    b.Property<string>("SKU")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Product_CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ProductMicroservice.ApplicationCore.Entities.Product_Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Parent_Category_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Product_Categories");
                });

            modelBuilder.Entity("ProductMicroservice.ApplicationCore.Entities.Product_Variation_Value", b =>
                {
                    b.Property<int>("Product_Id")
                        .HasColumnType("int");

                    b.Property<int>("Variation_Value_Id")
                        .HasColumnType("int");

                    b.HasKey("Product_Id", "Variation_Value_Id");

                    b.HasIndex("Variation_Value_Id");

                    b.ToTable("Product_Variation_Values");
                });

            modelBuilder.Entity("ProductMicroservice.ApplicationCore.Entities.Variation_Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Category_VariationId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Category_VariationId");

                    b.ToTable("Variation_Values");
                });

            modelBuilder.Entity("ProductMicroservice.ApplicationCore.Entities.Category_Variation", b =>
                {
                    b.HasOne("ProductMicroservice.ApplicationCore.Entities.Product_Category", "Product_Category")
                        .WithMany("Category_Variations")
                        .HasForeignKey("Product_CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product_Category");
                });

            modelBuilder.Entity("ProductMicroservice.ApplicationCore.Entities.Product", b =>
                {
                    b.HasOne("ProductMicroservice.ApplicationCore.Entities.Product_Category", "Product_Category")
                        .WithMany("Products")
                        .HasForeignKey("Product_CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product_Category");
                });

            modelBuilder.Entity("ProductMicroservice.ApplicationCore.Entities.Product_Variation_Value", b =>
                {
                    b.HasOne("ProductMicroservice.ApplicationCore.Entities.Product", "Product")
                        .WithMany("Product_Variation_Values")
                        .HasForeignKey("Product_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProductMicroservice.ApplicationCore.Entities.Variation_Value", "Variation_Value")
                        .WithMany("Product_Variation_Values")
                        .HasForeignKey("Variation_Value_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Variation_Value");
                });

            modelBuilder.Entity("ProductMicroservice.ApplicationCore.Entities.Variation_Value", b =>
                {
                    b.HasOne("ProductMicroservice.ApplicationCore.Entities.Category_Variation", "Category_Variation")
                        .WithMany("Variation_Values")
                        .HasForeignKey("Category_VariationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category_Variation");
                });

            modelBuilder.Entity("ProductMicroservice.ApplicationCore.Entities.Category_Variation", b =>
                {
                    b.Navigation("Variation_Values");
                });

            modelBuilder.Entity("ProductMicroservice.ApplicationCore.Entities.Product", b =>
                {
                    b.Navigation("Product_Variation_Values");
                });

            modelBuilder.Entity("ProductMicroservice.ApplicationCore.Entities.Product_Category", b =>
                {
                    b.Navigation("Category_Variations");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("ProductMicroservice.ApplicationCore.Entities.Variation_Value", b =>
                {
                    b.Navigation("Product_Variation_Values");
                });
#pragma warning restore 612, 618
        }
    }
}
