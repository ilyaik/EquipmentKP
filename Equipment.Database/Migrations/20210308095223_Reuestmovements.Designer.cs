﻿// <auto-generated />
using System;
using Equipment.Database.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Equipment.Database.Migrations
{
    [DbContext(typeof(EquipmentContext))]
    [Migration("20210308095223_Reuestmovements")]
    partial class Reuestmovements
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Equipment.Database.Entities.EquipmentCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EquipmentCategories");
                });

            modelBuilder.Entity("Equipment.Database.Entities.EquipmentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EquipmentCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EquipmentCategoryId");

                    b.ToTable("EquipmentTypes");
                });

            modelBuilder.Entity("Equipment.Database.Entities.EquipmentsKit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("InventoryNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Owner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReceiptDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("EquipmentsKits");
                });

            modelBuilder.Entity("Equipment.Database.Entities.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("Equipment.Database.Entities.MainEquipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EquipmentTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("EquipmentsKitId")
                        .HasColumnType("int");

                    b.Property<string>("IpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NetworkName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperationSystem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SerialNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EquipmentTypeId");

                    b.HasIndex("EquipmentsKitId");

                    b.ToTable("MainEquipment");
                });

            modelBuilder.Entity("Equipment.Database.Entities.Request", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MainEquipmentId")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MainEquipmentId");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("Equipment.Database.Entities.RequestMovement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RequestId")
                        .HasColumnType("int");

                    b.Property<int?>("RequestStateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RequestId");

                    b.HasIndex("RequestStateId");

                    b.ToTable("RequestMovements");
                });

            modelBuilder.Entity("Equipment.Database.Entities.RequestState", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RequestState");
                });

            modelBuilder.Entity("Equipment.Database.Entities.EquipmentType", b =>
                {
                    b.HasOne("Equipment.Database.Entities.EquipmentCategory", "EquipmentCategory")
                        .WithMany("EquipmentTypes")
                        .HasForeignKey("EquipmentCategoryId");

                    b.Navigation("EquipmentCategory");
                });

            modelBuilder.Entity("Equipment.Database.Entities.EquipmentsKit", b =>
                {
                    b.HasOne("Equipment.Database.Entities.Location", "Location")
                        .WithMany("EquipmentsKits")
                        .HasForeignKey("LocationId");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("Equipment.Database.Entities.MainEquipment", b =>
                {
                    b.HasOne("Equipment.Database.Entities.EquipmentType", "EquipmentType")
                        .WithMany("MainEquipments")
                        .HasForeignKey("EquipmentTypeId");

                    b.HasOne("Equipment.Database.Entities.EquipmentsKit", "EquipmentsKit")
                        .WithMany("MainEquipments")
                        .HasForeignKey("EquipmentsKitId");

                    b.Navigation("EquipmentsKit");

                    b.Navigation("EquipmentType");
                });

            modelBuilder.Entity("Equipment.Database.Entities.Request", b =>
                {
                    b.HasOne("Equipment.Database.Entities.MainEquipment", "MainEquipment")
                        .WithMany("Requests")
                        .HasForeignKey("MainEquipmentId");

                    b.Navigation("MainEquipment");
                });

            modelBuilder.Entity("Equipment.Database.Entities.RequestMovement", b =>
                {
                    b.HasOne("Equipment.Database.Entities.Request", "Request")
                        .WithMany("RequestMovements")
                        .HasForeignKey("RequestId");

                    b.HasOne("Equipment.Database.Entities.RequestState", "RequestState")
                        .WithMany("RequestMovements")
                        .HasForeignKey("RequestStateId");

                    b.Navigation("Request");

                    b.Navigation("RequestState");
                });

            modelBuilder.Entity("Equipment.Database.Entities.EquipmentCategory", b =>
                {
                    b.Navigation("EquipmentTypes");
                });

            modelBuilder.Entity("Equipment.Database.Entities.EquipmentType", b =>
                {
                    b.Navigation("MainEquipments");
                });

            modelBuilder.Entity("Equipment.Database.Entities.EquipmentsKit", b =>
                {
                    b.Navigation("MainEquipments");
                });

            modelBuilder.Entity("Equipment.Database.Entities.Location", b =>
                {
                    b.Navigation("EquipmentsKits");
                });

            modelBuilder.Entity("Equipment.Database.Entities.MainEquipment", b =>
                {
                    b.Navigation("Requests");
                });

            modelBuilder.Entity("Equipment.Database.Entities.Request", b =>
                {
                    b.Navigation("RequestMovements");
                });

            modelBuilder.Entity("Equipment.Database.Entities.RequestState", b =>
                {
                    b.Navigation("RequestMovements");
                });
#pragma warning restore 612, 618
        }
    }
}
