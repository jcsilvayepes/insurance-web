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
                });

            modelBuilder.Entity("Insurance.Web.Domain.Entities.PolicyEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CoverageMonth")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("InsuranceCoverageTypeId")
                        .HasColumnType("int");

                    b.Property<double>("InsurancePrice")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RiskTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Validity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InsuranceCoverageTypeId");

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
                });

            modelBuilder.Entity("Insurance.Web.Domain.Entities.PolicyEntity", b =>
                {
                    b.HasOne("Insurance.Web.Domain.Entities.PolicyCoverageTypeEntity", "InsuranceCoverageType")
                        .WithMany()
                        .HasForeignKey("InsuranceCoverageTypeId");

                    b.HasOne("Insurance.Web.Domain.Entities.RiskTypeEntity", "RiskType")
                        .WithMany()
                        .HasForeignKey("RiskTypeId");
                });
#pragma warning restore 612, 618
        }
    }
}
