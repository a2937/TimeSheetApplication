﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using TimeSheet.Data;
using System;

namespace TimeSheet.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("TimeSheet.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<Guid?>("DepartmentId");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("ExceptFromOvertime");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50);

                    b.Property<decimal>("HourlyWage");

                    b.Property<string>("LastName")
                        .HasMaxLength(50);

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("MiddleInitial")
                        .HasMaxLength(1);

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers","TimeSheet");
                });

            modelBuilder.Entity("TimeSheet.Models.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City")
                        .HasMaxLength(50);

                    b.Property<string>("CompanyName")
                        .HasMaxLength(50);

                    b.Property<string>("StateAbbreviated")
                        .HasMaxLength(2);

                    b.Property<string>("StreetAddress")
                        .HasMaxLength(50);

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<decimal>("WagesPaid");

                    b.HasKey("Id");

                    b.ToTable("Companies","TimeSheet");
                });

            modelBuilder.Entity("TimeSheet.Models.Department", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("CompanyId");

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<Guid?>("SupervisorId");

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("SupervisorId");

                    b.ToTable("Departments","TimeSheet");
                });

            modelBuilder.Entity("TimeSheet.Models.Supervisor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EmployeeId");

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Supervisors");
                });

            modelBuilder.Entity("TimeSheet.Models.WorkDay", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<string>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue("");

                    b.Property<decimal>("EstimatedPay")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasComputedColumnSql("TimeSheet.GetEstimatedPay([EmployeeId])");

                    b.Property<int>("HoursWorked")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasComputedColumnSql("DateDiff(hour,[SignIn], [SignOut])");

                    b.Property<bool>("IsApproved");

                    b.Property<bool>("IsVacationDay");

                    b.Property<string>("Reason")
                        .HasMaxLength(100);

                    b.Property<DateTimeOffset?>("SignIn")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTimeOffset?>("SignOut")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("WorkDays","TimeSheet");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TimeSheet.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TimeSheet.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TimeSheet.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TimeSheet.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TimeSheet.Models.ApplicationUser", b =>
                {
                    b.HasOne("TimeSheet.Models.Department", "Department")
                        .WithMany("AssignedEmployees")
                        .HasForeignKey("DepartmentId");
                });

            modelBuilder.Entity("TimeSheet.Models.Department", b =>
                {
                    b.HasOne("TimeSheet.Models.Company", "Company")
                        .WithMany("Departments")
                        .HasForeignKey("CompanyId");

                    b.HasOne("TimeSheet.Models.Supervisor", "Supervisor")
                        .WithMany("Departments")
                        .HasForeignKey("SupervisorId");
                });

            modelBuilder.Entity("TimeSheet.Models.Supervisor", b =>
                {
                    b.HasOne("TimeSheet.Models.ApplicationUser", "Manager")
                        .WithMany()
                        .HasForeignKey("EmployeeId");
                });

            modelBuilder.Entity("TimeSheet.Models.WorkDay", b =>
                {
                    b.HasOne("TimeSheet.Models.ApplicationUser", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");
                });
#pragma warning restore 612, 618
        }
    }
}
