﻿// <auto-generated />
using System;
using CRUD_Operations_With_Modal_Popup.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CRUD_Operations_With_Modal_Popup.Migrations
{
    [DbContext(typeof(HealthCareDbContext))]
    partial class HealthCareDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CRUD_Operations_With_Modal_Popup.Models.Entities.Patients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("Timestamp");

                    b.Property<int>("DoctorId")
                        .HasColumnType("INT");

                    b.Property<string>("FristName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("CRUD_Operations_With_Modal_Popup.Models.Entities.Physicians", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("DoctorId"));

                    b.Property<string>("DoctorFirstName")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("DoctorLastName")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<int>("SpecializationId")
                        .HasColumnType("INT");

                    b.HasKey("DoctorId");

                    b.HasIndex("SpecializationId");

                    b.ToTable("Physicians");
                });

            modelBuilder.Entity("CRUD_Operations_With_Modal_Popup.Models.Entities.Specializations", b =>
                {
                    b.Property<int>("SpecializationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("SpecializationId"));

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.Property<string>("Type")
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("SpecializationId");

                    b.ToTable("Specializations");
                });

            modelBuilder.Entity("CRUD_Operations_With_Modal_Popup.Models.Entities.Patients", b =>
                {
                    b.HasOne("CRUD_Operations_With_Modal_Popup.Models.Entities.Physicians", "Physician")
                        .WithMany("Patients")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Physician");
                });

            modelBuilder.Entity("CRUD_Operations_With_Modal_Popup.Models.Entities.Physicians", b =>
                {
                    b.HasOne("CRUD_Operations_With_Modal_Popup.Models.Entities.Specializations", "Specialization")
                        .WithMany("Physicians")
                        .HasForeignKey("SpecializationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Specialization");
                });

            modelBuilder.Entity("CRUD_Operations_With_Modal_Popup.Models.Entities.Physicians", b =>
                {
                    b.Navigation("Patients");
                });

            modelBuilder.Entity("CRUD_Operations_With_Modal_Popup.Models.Entities.Specializations", b =>
                {
                    b.Navigation("Physicians");
                });
#pragma warning restore 612, 618
        }
    }
}
