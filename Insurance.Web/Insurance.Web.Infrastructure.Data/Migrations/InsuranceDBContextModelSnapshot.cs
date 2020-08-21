﻿// <auto-generated />
using System;
using Insurance.Web.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Insurance.Web.Infrastructure.Data.Migrations
{
    [DbContext(typeof(InsuranceDBContext))]
    partial class InsuranceDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Insurance.Web.Domain.Entities.CoverageByPolicy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InsuranceId")
                        .HasColumnType("int");

                    b.Property<int>("PolicyCoverageTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("PolicyEntityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PolicyCoverageTypeId");

                    b.HasIndex("PolicyEntityId");

                    b.ToTable("CoverageByPolicy");
                });

            modelBuilder.Entity("Insurance.Web.Domain.Entities.PolicyCoverageTypeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PolicyCoverageTypeEntity");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Earthquake"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Fire"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Theft"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Loss"
                        });
                });

            modelBuilder.Entity("Insurance.Web.Domain.Entities.PolicyEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PercentageCoverage")
                        .HasColumnType("float");

                    b.Property<double>("PolicyPrice")
                        .HasColumnType("float");

                    b.Property<int?>("RiskTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Validity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RiskTypeId");

                    b.ToTable("Insurances");
                });

            modelBuilder.Entity("Insurance.Web.Domain.Entities.RiskTypeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RiskTypeEntity");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Low"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Mid"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Mid-low"
                        },
                        new
                        {
                            Id = 4,
                            Description = "High"
                        });
                });

            modelBuilder.Entity("Insurance.Web.Domain.Entities.CoverageByPolicy", b =>
                {
                    b.HasOne("Insurance.Web.Domain.Entities.PolicyCoverageTypeEntity", "PolicyCoverageType")
                        .WithMany()
                        .HasForeignKey("PolicyCoverageTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Insurance.Web.Domain.Entities.PolicyEntity", null)
                        .WithMany("CoverageByPolicy")
                        .HasForeignKey("PolicyEntityId");
                });

            modelBuilder.Entity("Insurance.Web.Domain.Entities.PolicyEntity", b =>
                {
                    b.HasOne("Insurance.Web.Domain.Entities.RiskTypeEntity", "RiskType")
                        .WithMany()
                        .HasForeignKey("RiskTypeId");
                });
#pragma warning restore 612, 618
        }
    }
}
