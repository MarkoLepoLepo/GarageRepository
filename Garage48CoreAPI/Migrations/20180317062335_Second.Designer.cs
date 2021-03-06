﻿// <auto-generated />
using Garage48CoreAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Garage48CoreAPI.Migrations
{
    [DbContext(typeof(PatientContext))]
    [Migration("20180317062335_Second")]
    partial class Second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Garage48CoreAPI.Models.PatientInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("PatientInformations");
                });

            modelBuilder.Entity("Garage48CoreAPI.Models.PersonalDatum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("UniqueId");

                    b.HasKey("Id");

                    b.ToTable("PersonalData");
                });
#pragma warning restore 612, 618
        }
    }
}
