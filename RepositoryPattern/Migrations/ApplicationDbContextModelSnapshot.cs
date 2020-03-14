﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RepositoryPattern.Data;

namespace RepositoryPattern.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RepositoryPattern.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<DateTime>("DOB");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("Gender");

                    b.Property<string>("LastName");

                    b.Property<string>("MiddleName");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("RepositoryPattern.Models.PaymentRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("ContractualEarnings");

                    b.Property<decimal>("ContractualHours");

                    b.Property<int>("EmployeeId");

                    b.Property<decimal>("HourlyRate");

                    b.Property<decimal>("HoursWorked");

                    b.Property<decimal>("NIC");

                    b.Property<decimal>("NetPayment");

                    b.Property<decimal>("OvertimeEarnings");

                    b.Property<decimal>("OvertimeHours");

                    b.Property<DateTime>("PayDate");

                    b.Property<string>("PayMonth");

                    b.Property<decimal?>("SLC");

                    b.Property<decimal>("Tax");

                    b.Property<int>("TaxYearId");

                    b.Property<decimal>("TotalDeduction");

                    b.Property<decimal>("TotalEarnings");

                    b.Property<decimal?>("UnionFee");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("TaxYearId");

                    b.ToTable("PaymentRecords");
                });

            modelBuilder.Entity("RepositoryPattern.Models.TaxYear", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("YearOfTax");

                    b.HasKey("Id");

                    b.ToTable("TaxYears");
                });

            modelBuilder.Entity("RepositoryPattern.Models.PaymentRecord", b =>
                {
                    b.HasOne("RepositoryPattern.Models.Employee", "Employee")
                        .WithMany("PaymentRecords")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RepositoryPattern.Models.TaxYear", "TaxYear")
                        .WithMany("PaymentRecords")
                        .HasForeignKey("TaxYearId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
