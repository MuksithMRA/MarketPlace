﻿// <auto-generated />
using MarketPlace.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MarketPlace.Migrations {
[DbContext(typeof(DataContext))]
[Migration("20230128133714_product_edit2")]
partial class product_edit2 {
  protected override void BuildTargetModel(ModelBuilder modelBuilder) {
#pragma warning disable 612, 618
    modelBuilder.HasAnnotation("ProductVersion", "6.0.13")
        .HasAnnotation("Relational:MaxIdentifierLength", 64);

    modelBuilder.Entity("MarketPlace.Models.Brand", b => {
      b.Property<int>("Id")
          .ValueGeneratedOnAdd()
          .HasColumnType("int")
          .HasColumnName("id");

      b.Property<string>("description")
          .IsRequired()
          .HasColumnType("longtext")
          .HasColumnName("description");

      b.Property<string>("image")
          .IsRequired()
          .HasMaxLength(255)
          .HasColumnType("varchar(255)")
          .HasColumnName("image");

      b.Property<string>("title")
          .IsRequired()
          .HasMaxLength(255)
          .HasColumnType("varchar(255)")
          .HasColumnName("name");

      b.HasKey("Id");

      b.ToTable("Brand");
    });

    modelBuilder.Entity("MarketPlace.Models.Category", b => {
      b.Property<int>("Id")
          .ValueGeneratedOnAdd()
          .HasColumnType("int")
          .HasColumnName("id");

      b.Property<string>("Description")
          .IsRequired()
          .HasColumnType("longtext")
          .HasColumnName("description");

      b.Property<string>("Image")
          .IsRequired()
          .HasMaxLength(255)
          .HasColumnType("varchar(255)")
          .HasColumnName("image");

      b.Property<string>("Title")
          .IsRequired()
          .HasMaxLength(255)
          .HasColumnType("varchar(255)")
          .HasColumnName("name");

      b.HasKey("Id");

      b.ToTable("Category");
    });

    modelBuilder.Entity("MarketPlace.Models.Location", b => {
      b.Property<int>("Id")
          .ValueGeneratedOnAdd()
          .HasColumnType("int")
          .HasColumnName("id");

      b.Property<string>("Address")
          .IsRequired()
          .HasColumnType("longtext")
          .HasColumnName("address");

      b.Property<double>("Latitude")
          .HasColumnType("double")
          .HasColumnName("latitude");

      b.Property<double>("Longitude")
          .HasColumnType("double")
          .HasColumnName("longitude");

      b.HasKey("Id");

      b.ToTable("Location");
    });

    modelBuilder.Entity("MarketPlace.Models.Member", b => {
      b.Property<int>("Id")
          .ValueGeneratedOnAdd()
          .HasColumnType("int")
          .HasColumnName("id");

      b.Property<string>("FirstName")
          .IsRequired()
          .HasMaxLength(255)
          .HasColumnType("varchar(255)")
          .HasColumnName("first_name");

      b.Property<string>("LastName")
          .IsRequired()
          .HasMaxLength(255)
          .HasColumnType("varchar(255)")
          .HasColumnName("last_name");

      b.Property<int>("LocationId")
          .HasColumnType("int")
          .HasColumnName("location_id");

      b.Property<int>("PhoneNumber")
          .HasColumnType("int")
          .HasColumnName("phone_number");

      b.HasKey("Id");

      b.HasIndex("LocationId");

      b.ToTable("Member");
    });

    modelBuilder.Entity("MarketPlace.Models.Product", b => {
      b.Property<int>("Id")
          .ValueGeneratedOnAdd()
          .HasColumnType("int")
          .HasColumnName("id");

      b.Property<int>("CategoryId")
          .HasColumnType("int")
          .HasColumnName("category_id");

      b.Property<string>("Description")
          .IsRequired()
          .HasColumnType("longtext")
          .HasColumnName("description");

      b.Property<double>("Price").HasColumnType("double").HasColumnName(
          "price");

      b.Property<int>("Qty").HasColumnType("int").HasColumnName("qty");

      b.Property<double>("ShippingFee")
          .HasColumnType("double")
          .HasColumnName("shipping_fee");

      b.Property<int>("StoreId").HasColumnType("int").HasColumnName("store_id");

      b.Property<int>("SubCategoryId")
          .HasColumnType("int")
          .HasColumnName("sub_category_id");

      b.Property<string>("Thumbnail")
          .IsRequired()
          .HasMaxLength(255)
          .HasColumnType("varchar(255)")
          .HasColumnName("thumbnail");

      b.Property<string>("Title")
          .IsRequired()
          .HasMaxLength(255)
          .HasColumnType("varchar(255)")
          .HasColumnName("name");

      b.HasKey("Id");

      b.HasIndex("CategoryId");

      b.HasIndex("StoreId");

      b.HasIndex("SubCategoryId");

      b.ToTable("Products");
    });

    modelBuilder.Entity("MarketPlace.Models.ProductImage", b => {
      b.Property<int>("Id")
          .ValueGeneratedOnAdd()
          .HasColumnType("int")
          .HasColumnName("id");

      b.Property<string>("Image")
          .IsRequired()
          .HasColumnType("longtext")
          .HasColumnName("image");

      b.Property<int>("ProductId")
          .HasColumnType("int")
          .HasColumnName("product_id");

      b.HasKey("Id");

      b.HasIndex("ProductId");

      b.ToTable("ProductImage");
    });

    modelBuilder.Entity("MarketPlace.Models.Store", b => {
      b.Property<int>("Id")
          .ValueGeneratedOnAdd()
          .HasColumnType("int")
          .HasColumnName("id");

      b.Property<string>("Description")
          .IsRequired()
          .HasColumnType("longtext")
          .HasColumnName("description");

      b.Property<string>("Image")
          .IsRequired()
          .HasMaxLength(255)
          .HasColumnType("varchar(255)")
          .HasColumnName("image");

      b.Property<int>("LocationId")
          .HasColumnType("int")
          .HasColumnName("location_id");

      b.Property<string>("Title")
          .IsRequired()
          .HasMaxLength(255)
          .HasColumnType("varchar(255)")
          .HasColumnName("name");

      b.HasKey("Id");

      b.HasIndex("LocationId");

      b.ToTable("Stores");
    });

    modelBuilder.Entity("MarketPlace.Models.SubCategory", b => {
      b.Property<int>("Id")
          .ValueGeneratedOnAdd()
          .HasColumnType("int")
          .HasColumnName("id");

      b.Property<int>("BrandId").HasColumnType("int").HasColumnName("brand_id");

      b.Property<int>("CategoryId")
          .HasColumnType("int")
          .HasColumnName("category_id");

      b.Property<string>("Description")
          .IsRequired()
          .HasColumnType("longtext")
          .HasColumnName("description");

      b.Property<string>("Image")
          .IsRequired()
          .HasMaxLength(255)
          .HasColumnType("varchar(255)")
          .HasColumnName("image");

      b.Property<string>("Title")
          .IsRequired()
          .HasMaxLength(255)
          .HasColumnType("varchar(255)")
          .HasColumnName("name");

      b.HasKey("Id");

      b.HasIndex("BrandId");

      b.HasIndex("CategoryId");

      b.ToTable("Sub_Category");
    });

    modelBuilder.Entity("MarketPlace.Models.User", b => {
      b.Property<int>("Id")
          .ValueGeneratedOnAdd()
          .HasColumnType("int")
          .HasColumnName("id");

      b.Property<string>("Email")
          .IsRequired()
          .HasMaxLength(255)
          .HasColumnType("varchar(255)")
          .HasColumnName("email");

      b.Property<int>("MemberId")
          .HasColumnType("int")
          .HasColumnName("member_id");

      b.Property<string>("Password")
          .IsRequired()
          .HasMaxLength(20)
          .HasColumnType("varchar(20)")
          .HasColumnName("password");

      b.Property<string>("Role")
          .IsRequired()
          .HasColumnType("longtext")
          .HasColumnName("role");

      b.HasKey("Id");

      b.HasIndex("MemberId");

      b.ToTable("User");
    });

    modelBuilder.Entity("MarketPlace.Models.Member", b => {
      b.HasOne("MarketPlace.Models.Location", "Location")
          .WithMany()
          .HasForeignKey("LocationId")
          .OnDelete(DeleteBehavior.Cascade)
          .IsRequired();

      b.Navigation("Location");
    });

    modelBuilder.Entity("MarketPlace.Models.Product", b => {
      b.HasOne("MarketPlace.Models.Category", "category")
          .WithMany()
          .HasForeignKey("CategoryId")
          .OnDelete(DeleteBehavior.Cascade)
          .IsRequired();

      b.HasOne("MarketPlace.Models.Store", "Store")
          .WithMany("Products")
          .HasForeignKey("StoreId")
          .OnDelete(DeleteBehavior.Cascade)
          .IsRequired();

      b.HasOne("MarketPlace.Models.SubCategory", "SubCategory")
          .WithMany()
          .HasForeignKey("SubCategoryId")
          .OnDelete(DeleteBehavior.Cascade)
          .IsRequired();

      b.Navigation("Store");

      b.Navigation("SubCategory");

      b.Navigation("category");
    });

    modelBuilder.Entity("MarketPlace.Models.ProductImage", b => {
      b.HasOne("MarketPlace.Models.Product", "product")
          .WithMany("ProductImages")
          .HasForeignKey("ProductId")
          .OnDelete(DeleteBehavior.Cascade)
          .IsRequired();

      b.Navigation("product");
    });

    modelBuilder.Entity("MarketPlace.Models.Store", b => {
      b.HasOne("MarketPlace.Models.Location", "Location")
          .WithMany()
          .HasForeignKey("LocationId")
          .OnDelete(DeleteBehavior.Cascade)
          .IsRequired();

      b.Navigation("Location");
    });

    modelBuilder.Entity("MarketPlace.Models.SubCategory", b => {
      b.HasOne("MarketPlace.Models.Brand", "Brand")
          .WithMany()
          .HasForeignKey("BrandId")
          .OnDelete(DeleteBehavior.Cascade)
          .IsRequired();

      b.HasOne("MarketPlace.Models.Category", "Category")
          .WithMany("SubCategories")
          .HasForeignKey("CategoryId")
          .OnDelete(DeleteBehavior.Cascade)
          .IsRequired();

      b.Navigation("Brand");

      b.Navigation("Category");
    });

    modelBuilder.Entity("MarketPlace.Models.User", b => {
      b.HasOne("MarketPlace.Models.Member", "Member")
          .WithMany()
          .HasForeignKey("MemberId")
          .OnDelete(DeleteBehavior.Cascade)
          .IsRequired();

      b.Navigation("Member");
    });

    modelBuilder.Entity("MarketPlace.Models.Category",
                        b => { b.Navigation("SubCategories"); });

    modelBuilder.Entity("MarketPlace.Models.Product",
                        b => { b.Navigation("ProductImages"); });

    modelBuilder.Entity("MarketPlace.Models.Store",
                        b => { b.Navigation("Products"); });
#pragma warning restore 612, 618
  }
}
}
