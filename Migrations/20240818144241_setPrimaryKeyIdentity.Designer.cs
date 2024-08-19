﻿// <auto-generated />
using System;
using HagagCompany.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HagagCompany.Migrations
{
    [DbContext(typeof(HagagCompanyContext))]
    [Migration("20240818144241_setPrimaryKeyIdentity")]
    partial class setPrimaryKeyIdentity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HagagCompany.Entities.Employee", b =>
                {
                    b.Property<int>("EmpolyeeId")
                        .HasColumnType("int")
                        .HasColumnName("EmpolyeeID");

                    b.Property<string>("EmailId")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("EmailID");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int?>("JobId")
                        .HasColumnType("int")
                        .HasColumnName("JobID");

                    b.Property<DateTime?>("JoiningDate")
                        .HasColumnType("datetime");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int?>("Number")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("EmpolyeeId")
                        .HasName("PK__Employee__D86EFD0665445ADE");

                    b.HasIndex("JobId");

                    b.HasIndex(new[] { "Number" }, "UQ__Employee__3214EC263AE63FC6")
                        .IsUnique()
                        .HasFilter("[ID] IS NOT NULL");

                    b.HasIndex(new[] { "EmailId" }, "UQ__Employee__7ED91AEE9F08D90E")
                        .IsUnique();

                    b.HasIndex(new[] { "PhoneNumber" }, "UQ__Employee__85FB4E38AEA842F6")
                        .IsUnique()
                        .HasFilter("[PhoneNumber] IS NOT NULL");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("HagagCompany.Entities.Job", b =>
                {
                    b.Property<int>("JobId")
                        .HasColumnType("int")
                        .HasColumnName("JobID");

                    b.Property<string>("JobName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("JobId")
                        .HasName("PK__Jobs__056690E240B58DD3");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("HagagCompany.Entities.User", b =>
                {
                    b.Property<string>("UserName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Password")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.HasKey("UserName", "Password")
                        .HasName("Log_Pk");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("HagagCompany.Entities.Employee", b =>
                {
                    b.HasOne("HagagCompany.Entities.Job", "Job")
                        .WithMany("Employees")
                        .HasForeignKey("JobId")
                        .HasConstraintName("EmpolyeeJop_FK");

                    b.Navigation("Job");
                });

            modelBuilder.Entity("HagagCompany.Entities.Job", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
