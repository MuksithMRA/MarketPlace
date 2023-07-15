﻿// <auto-generated />
using MarketPlace.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MarketPlace.Migrations {
[DbContext(typeof(DataContext))]
[Migration("20230128114100_sub_category_table_added1")]
partial class sub_category_table_added1 {
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
            .HasColumnName("title");

            b.HasKey("Id");

            b.ToTable("Brand");
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

        modelBuilder.Entity("MarketPlace.Models.SubCategory", b => {
            b.Property<int>("Id")
            .ValueGeneratedOnAdd()
            .HasColumnType("int")
            .HasColumnName("id");

            b.Property<int>("BrandId").HasColumnType("int").HasColumnName("brand_id");

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
            .HasColumnName("title");

            b.HasKey("Id");

            b.HasIndex("BrandId");

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

        modelBuilder.Entity("MarketPlace.Models.SubCategory", b => {
            b.HasOne("MarketPlace.Models.Brand", "Brand")
            .WithMany()
            .HasForeignKey("BrandId")
            .OnDelete(DeleteBehavior.Cascade)
            .IsRequired();

            b.Navigation("Brand");
        });

        modelBuilder.Entity("MarketPlace.Models.User", b => {
            b.HasOne("MarketPlace.Models.Member", "Member")
            .WithMany()
            .HasForeignKey("MemberId")
            .OnDelete(DeleteBehavior.Cascade)
            .IsRequired();

            b.Navigation("Member");
        });
#pragma warning restore 612, 618
    }
}
}
