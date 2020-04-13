using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using DAL.Entities;

namespace DAL.DataContext
{
    public class DatabaseContext : DbContext
    {
        public class OptionsBuild
        {
            public OptionsBuild()
            {
                Settings = new AppConfiguration();
                OpsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
                OpsBuilder.UseSqlServer(Settings.SqlConnectionString);
                DbOptions = OpsBuilder.Options;
            }

            public DbContextOptionsBuilder<DatabaseContext> OpsBuilder { get; set; }
            public DbContextOptions<DatabaseContext> DbOptions { get; set; }
            private AppConfiguration Settings { get; set; }
        }

        public static OptionsBuild Ops = new OptionsBuild();

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) {}

        public DbSet<InsuranceClient> InsuranceClients { get; set; }
    }
}
