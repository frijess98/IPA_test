﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SCE.ServicingPartnerInfoCheck.DAL.Migrations
{
    [DbContext(typeof(SpInfoCheckContext))]
    [Migration("20210421133541_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            #pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("spInfoCheck")
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SCE.ServicingPartnerInfoCheck.Contracts.Types.ServicingPartnerInfoCheckEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsSuccessful")
                        .HasColumnType("bit");

                    b.Property<string>("RequestId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResponseJSON")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServicingPartnerKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SpInfoCheckEntities");
                });
            #pragma warning restore 612, 618
        }
    }
}
