﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TodoList.Data;

namespace TodoList.Migrations
{
    [DbContext(typeof(TodoContext))]
    [Migration("20201026161603_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TodoList.Models.BinhLuan", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CongViecID")
                        .HasColumnType("int");

                    b.Property<string>("NoiDung")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CongViecID");

                    b.ToTable("DSBinhLuan");
                });

            modelBuilder.Entity("TodoList.Models.CongViec", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NhanVienID")
                        .HasColumnType("int");

                    b.Property<int>("Privacy")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("NhanVienID");

                    b.ToTable("DSCongViec");
                });

            modelBuilder.Entity("TodoList.Models.NguoiLamChung", b =>
                {
                    b.Property<int>("NguoiLamChungID")
                        .HasColumnType("int");

                    b.Property<int>("CongViecID")
                        .HasColumnType("int");

                    b.HasKey("NguoiLamChungID");

                    b.HasIndex("CongViecID");

                    b.ToTable("DSNguoiLamChung");
                });

            modelBuilder.Entity("TodoList.Models.NhanVien", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoTen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("DSNhanVien");
                });

            modelBuilder.Entity("TodoList.Models.BinhLuan", b =>
                {
                    b.HasOne("TodoList.Models.CongViec", "CongViec")
                        .WithMany()
                        .HasForeignKey("CongViecID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TodoList.Models.CongViec", b =>
                {
                    b.HasOne("TodoList.Models.NhanVien", "NhanVien")
                        .WithMany("DSCongViec")
                        .HasForeignKey("NhanVienID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TodoList.Models.NguoiLamChung", b =>
                {
                    b.HasOne("TodoList.Models.CongViec", "CongViec")
                        .WithMany("NguoiLamChung")
                        .HasForeignKey("CongViecID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TodoList.Models.NhanVien", "NhanVien")
                        .WithMany()
                        .HasForeignKey("NguoiLamChungID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
