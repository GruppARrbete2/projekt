﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(TemplateDBContext))]
    [Migration("20211218135128_Test5454")]
    partial class Test5454
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("API.Models.Door", b =>
                {
                    b.Property<int>("DoorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DoorID"), 1L, 1);

                    b.Property<string>("DörrBenämning")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Explanation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LocationID")
                        .HasColumnType("int");

                    b.HasKey("DoorID");

                    b.HasIndex("LocationID");

                    b.ToTable("Doors");

                    b.HasData(
                        new
                        {
                            DoorID = 1,
                            DörrBenämning = "Tvätt",
                            Explanation = "Dörr mot tvättstuga"
                        },
                        new
                        {
                            DoorID = 2,
                            DörrBenämning = "LGH",
                            Explanation = "Dörr till lägenhet"
                        });
                });

            modelBuilder.Entity("API.Models.DoorOpened", b =>
                {
                    b.Property<Guid?>("DoorOpenedId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("DoorID")
                        .HasColumnType("int");

                    b.Property<int?>("TenantID")
                        .HasColumnType("int");

                    b.Property<TimeSpan?>("Time")
                        .HasColumnType("time");

                    b.HasKey("DoorOpenedId");

                    b.ToTable("DoorsOpened");
                });

            modelBuilder.Entity("API.Models.Location", b =>
                {
                    b.Property<int>("LocationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocationID"), 1L, 1);

                    b.HasKey("LocationID");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("API.Models.Output", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DörrBenämning")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Person")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tag")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("Time")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.ToTable("Outputs");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Code = "DÖIN",
                            DörrBenämning = "TVÄTT",
                            Person = "Ella Ahlström",
                            Tag = "0301A",
                            Time = 637754358879726706L
                        },
                        new
                        {
                            ID = 2,
                            Code = "DÖUT",
                            DörrBenämning = "TVÄTT",
                            Person = "Ella Ahlström",
                            Tag = "0301A",
                            Time = 637754358879726742L
                        },
                        new
                        {
                            ID = 3,
                            Code = "DÖIN",
                            DörrBenämning = "Lägenhet",
                            Person = "Göran Ahlström",
                            Tag = "0302A",
                            Time = 637754358879726745L
                        },
                        new
                        {
                            ID = 4,
                            Code = "DÖIN",
                            DörrBenämning = "Lägenhet",
                            Person = "Göran Ahlström",
                            Tag = "0302A",
                            Time = 637754358879726747L
                        },
                        new
                        {
                            ID = 5,
                            Code = "DÖIN",
                            DörrBenämning = "Lägenhet",
                            Person = "Göran Ahlström",
                            Tag = "0302A",
                            Time = 637754358879726749L
                        },
                        new
                        {
                            ID = 6,
                            Code = "DÖIN",
                            DörrBenämning = "Lägenhet",
                            Person = "Göran Ahlström",
                            Tag = "0302A",
                            Time = 637754358879726752L
                        },
                        new
                        {
                            ID = 7,
                            Code = "DÖIN",
                            DörrBenämning = "Lägenhet",
                            Person = "Göran Ahlström",
                            Tag = "0302A",
                            Time = 637754358879726754L
                        },
                        new
                        {
                            ID = 8,
                            Code = "DÖIN",
                            DörrBenämning = "Lägenhet",
                            Person = "Göran Ahlström",
                            Tag = "0302A",
                            Time = 637754358879726756L
                        },
                        new
                        {
                            ID = 9,
                            Code = "DÖIN",
                            DörrBenämning = "Lägenhet",
                            Person = "Göran Ahlström",
                            Tag = "0302A",
                            Time = 637754358879726758L
                        },
                        new
                        {
                            ID = 10,
                            Code = "DÖIN",
                            DörrBenämning = "Lägenhet",
                            Person = "Göran Ahlström",
                            Tag = "0302A",
                            Time = 637754358879726760L
                        },
                        new
                        {
                            ID = 11,
                            Code = "DÖIN",
                            DörrBenämning = "TVÄTT",
                            Person = "Ella Ahlström",
                            Tag = "0301A",
                            Time = 637754358879726762L
                        },
                        new
                        {
                            ID = 12,
                            Code = "DÖIN",
                            DörrBenämning = "TVÄTT",
                            Person = "Ella Ahlström",
                            Tag = "0301A",
                            Time = 637754358879726764L
                        },
                        new
                        {
                            ID = 13,
                            Code = "DÖIN",
                            DörrBenämning = "TVÄTT",
                            Person = "Ella Ahlström",
                            Tag = "0301A",
                            Time = 637754358879726766L
                        },
                        new
                        {
                            ID = 14,
                            Code = "DÖIN",
                            DörrBenämning = "TVÄTT",
                            Person = "Ella Ahlström",
                            Tag = "0301A",
                            Time = 637754358879726769L
                        },
                        new
                        {
                            ID = 15,
                            Code = "DÖIN",
                            DörrBenämning = "TVÄTT",
                            Person = "Ella Ahlström",
                            Tag = "0301A",
                            Time = 637754358879726771L
                        },
                        new
                        {
                            ID = 16,
                            Code = "DÖIN",
                            DörrBenämning = "TVÄTT",
                            Person = "Ella Ahlström",
                            Tag = "0301A",
                            Time = 637754358879726773L
                        },
                        new
                        {
                            ID = 17,
                            Code = "DÖIN",
                            DörrBenämning = "TVÄTT",
                            Person = "Ella Ahlström",
                            Tag = "0301A",
                            Time = 637754358879726775L
                        },
                        new
                        {
                            ID = 18,
                            Code = "DÖIN",
                            DörrBenämning = "TVÄTT",
                            Person = "Ella Ahlström",
                            Tag = "0301A",
                            Time = 637754358879726777L
                        },
                        new
                        {
                            ID = 19,
                            Code = "DÖIN",
                            DörrBenämning = "TVÄTT",
                            Person = "Ella Ahlström",
                            Tag = "0301A",
                            Time = 637754358879726779L
                        },
                        new
                        {
                            ID = 20,
                            Code = "DÖIN",
                            DörrBenämning = "TVÄTT",
                            Person = "Ella Ahlström",
                            Tag = "0301A",
                            Time = 637754358879726780L
                        },
                        new
                        {
                            ID = 21,
                            Code = "DÖIN",
                            DörrBenämning = "TVÄTT",
                            Person = "Ella Ahlström",
                            Tag = "0301A",
                            Time = 637754358879726783L
                        },
                        new
                        {
                            ID = 22,
                            Code = "DÖIN",
                            DörrBenämning = "TVÄTT",
                            Person = "Ella Ahlström",
                            Tag = "0301A",
                            Time = 637754358879726785L
                        });
                });

            modelBuilder.Entity("API.Models.Tenant", b =>
                {
                    b.Property<int>("TenantID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TenantID"), 1L, 1);

                    b.Property<int>("Apartment")
                        .HasColumnType("int");

                    b.Property<int?>("LocationID")
                        .HasColumnType("int");

                    b.Property<string>("Namne")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tag")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TenantID");

                    b.HasIndex("LocationID");

                    b.ToTable("Tenants");

                    b.HasData(
                        new
                        {
                            TenantID = 1,
                            Apartment = 1001,
                            Namne = "Göran Svensson",
                            Tag = "1001A"
                        },
                        new
                        {
                            TenantID = 2,
                            Apartment = 1002,
                            Namne = "Göran Andersson",
                            Tag = "1002A"
                        },
                        new
                        {
                            TenantID = 3,
                            Apartment = 1002,
                            Namne = "Jonas Andersson",
                            Tag = "1002B"
                        },
                        new
                        {
                            TenantID = 4,
                            Apartment = 1001,
                            Namne = "Stefan Andersson",
                            Tag = "1002B"
                        });
                });

            modelBuilder.Entity("API.Models.Door", b =>
                {
                    b.HasOne("API.Models.Location", null)
                        .WithMany("Doors")
                        .HasForeignKey("LocationID");
                });

            modelBuilder.Entity("API.Models.Tenant", b =>
                {
                    b.HasOne("API.Models.Location", null)
                        .WithMany("Tenants")
                        .HasForeignKey("LocationID");
                });

            modelBuilder.Entity("API.Models.Location", b =>
                {
                    b.Navigation("Doors");

                    b.Navigation("Tenants");
                });
#pragma warning restore 612, 618
        }
    }
}
