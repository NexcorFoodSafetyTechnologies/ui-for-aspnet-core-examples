﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SqlServerDataBase.Models;

namespace SqlServerDataBase.Migrations
{
    [DbContext(typeof(EventsDbContext))]
    partial class EventsDbContecstModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SqlServerDataBase.Models.Task", b =>
                {
                    b.Property<int>("TaskID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("End")
                        .HasColumnType("datetime2");

                    b.Property<string>("EndTimezone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAllDay")
                        .HasColumnType("bit");

                    b.Property<string>("RecurrenceException")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RecurrenceID")
                        .HasColumnType("int");

                    b.Property<string>("RecurrenceRule")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.Property<string>("StartTimezone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Task1TaskID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TaskID");

                    b.HasIndex("Task1TaskID");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("SqlServerDataBase.Models.Task", b =>
                {
                    b.HasOne("SqlServerDataBase.Models.Task", "Task1")
                        .WithMany("Tasks1")
                        .HasForeignKey("Task1TaskID");
                });
#pragma warning restore 612, 618
        }
    }
}