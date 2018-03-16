﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using VinylCollection.Models;

namespace VinylCollection.Migrations
{
    [DbContext(typeof(LibraryContext))]
    partial class LibraryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VinylCollection.Models.Library", b =>
                {
                    b.Property<Guid>("CollectorID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("CollectorID");

                    b.ToTable("Library");
                });

            modelBuilder.Entity("VinylCollection.Models.Record", b =>
                {
                    b.Property<Guid>("CollectorID")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("LibraryCollectorID");

                    b.Property<int>("Rating");

                    b.Property<string>("Title");

                    b.HasKey("CollectorID");

                    b.HasIndex("LibraryCollectorID");

                    b.ToTable("Record");
                });

            modelBuilder.Entity("VinylCollection.Models.Record", b =>
                {
                    b.HasOne("VinylCollection.Models.Library")
                        .WithMany("RecordList")
                        .HasForeignKey("LibraryCollectorID");
                });
#pragma warning restore 612, 618
        }
    }
}
