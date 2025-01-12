﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NonProfitSiteV3.Data;

#nullable disable

namespace NonProfitSiteV3.Migrations
{
    [DbContext(typeof(AppDbContext01))]
    partial class AppDbContext01ModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("NonProfitSiteV3.Models.BloodDoner", b =>
                {
                    b.Property<int>("BB_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BB_Id"), 1L, 1);

                    b.Property<string>("BB_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BB_blodtype")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BB_contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BB_deadline")
                        .HasColumnType("int");

                    b.Property<string>("BB_email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BB_father")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BB_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BB_occupation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BB_quantity")
                        .HasColumnType("int");

                    b.HasKey("BB_Id");

                    b.ToTable("BloodDonerTable");
                });

            modelBuilder.Entity("NonProfitSiteV3.Models.FinancialAid", b =>
                {
                    b.Property<int>("AID_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AID_Id"), 1L, 1);

                    b.Property<string>("AID_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AID_contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AID_email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AID_father")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AID_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AID_occupation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AID_reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AID_Id");

                    b.ToTable("FinancialAidTable");
                });

            modelBuilder.Entity("NonProfitSiteV3.Models.VolunteerRequest", b =>
                {
                    b.Property<int>("VLreq_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VLreq_Id"), 1L, 1);

                    b.Property<string>("VLreq_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VLreq_contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VLreq_email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VLreq_father")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VLreq_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VLreq_occupation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VLreq_quantity")
                        .HasColumnType("int");

                    b.Property<string>("VLreq_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VLreq_Id");

                    b.ToTable("VolunteerReqTable");
                });
#pragma warning restore 612, 618
        }
    }
}
