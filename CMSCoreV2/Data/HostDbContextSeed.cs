﻿using CMSCoreV2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMSCoreV2.Data
{
    public static class HostDbContextSeed
    {
        public static void Seed(this HostDbContext context)
        {
            // migration'ları veritabanına uygula
            context.Database.Migrate();

            // Look for any tenants record.
            if (context.AppTenants.Any())
            {
                return;   // DB has been seeded
            }
            // Perform seed operations
            AddAppTenants(context);
        }

        public static void AddAppTenants(HostDbContext context)
        {
            var appTenant = new AppTenant();
            appTenant.Name = "birinsan";
            appTenant.Title = "Bir İnsan";
            appTenant.Hostname = "localhost:60002";
            appTenant.Theme = "edugate";
            appTenant.ConnectionString = $"Server=.;Database={appTenant.Name};Trusted_Connection=True;MultipleActiveResultSets=true";
            context.AppTenants.Add(appTenant);

            var appTenant2 = new AppTenant();
            appTenant2.Name = "bilgikoleji";
            appTenant2.Title = "Bilgi Koleji";
            appTenant2.Hostname = "localhost:60001";
            appTenant2.Theme = "edugate";
            appTenant2.ConnectionString = $"Server=.;Database={appTenant2.Name};Trusted_Connection=True;MultipleActiveResultSets=true";
            context.AppTenants.Add(appTenant2);
            context.SaveChanges();
        }

    }
}
