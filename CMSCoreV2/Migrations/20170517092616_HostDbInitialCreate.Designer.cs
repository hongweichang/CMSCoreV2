﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CMSCoreV2.Data;

namespace CMSCoreV2.Migrations
{
    [DbContext(typeof(HostDbContext))]
    [Migration("20170517092616_HostDbInitialCreate")]
    partial class HostDbInitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CMSCoreV2.Models.AppTenant", b =>
                {
                    b.Property<string>("AppTenantId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConnectionString");

                    b.Property<string>("Hostname");

                    b.Property<string>("Name");

                    b.Property<string>("Theme");

                    b.Property<string>("Title");

                    b.HasKey("AppTenantId");

                    b.ToTable("AppTenants");
                });
        }
    }
}
