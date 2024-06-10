﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using bshbbackend;

#nullable disable

namespace bshbbackend.Migrations
{
    [DbContext(typeof(BshbDbContext))]
    [Migration("20240607055725_subnotice")]
    partial class subnotice
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("bshbbackend.Models.Chairman", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("From")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Photo")
                        .IsRequired()
                        .HasColumnType("VARBINARY(MAX)");

                    b.Property<DateTime>("To")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Chairmen");
                });

            modelBuilder.Entity("bshbbackend.Models.ContactList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ContactLists");
                });

            modelBuilder.Entity("bshbbackend.Models.CurrentTenders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("LastDateOfsubmission")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TenderDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CurrentTender");
                });

            modelBuilder.Entity("bshbbackend.Models.EmployeeList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EmployeeLists");
                });

            modelBuilder.Entity("bshbbackend.Models.HeaderLogo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<byte[]>("Img1")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Img15")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Img2")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Img3")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Img4")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Img6")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Img7")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Img8")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Img9")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("url1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("url2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("url3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("url4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("url5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("url6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("url7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("url8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("url9")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("HeaderLogos");
                });

            modelBuilder.Entity("bshbbackend.Models.MDList", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("From")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Photo")
                        .IsRequired()
                        .HasColumnType("VARBINARY(MAX)");

                    b.Property<DateTime>("To")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("MDLists");
                });

            modelBuilder.Entity("bshbbackend.Models.MDMessage", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("Createddate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Updateddate")
                        .HasColumnType("datetime2");

                    b.Property<string>("message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("MDMessages");
                });

            modelBuilder.Entity("bshbbackend.Models.Notice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Notices");
                });

            modelBuilder.Entity("bshbbackend.Models.OfficerList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Photo")
                        .IsRequired()
                        .HasColumnType("VARBINARY(MAX)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OfficerLists");
                });

            modelBuilder.Entity("bshbbackend.Models.PhotoGallery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("Photo")
                        .IsRequired()
                        .HasColumnType("VARBINARY(MAX)");

                    b.HasKey("Id");

                    b.ToTable("PhotoGallerys");
                });

            modelBuilder.Entity("bshbbackend.Models.SubNotice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SubNotices");
                });
#pragma warning restore 612, 618
        }
    }
}
