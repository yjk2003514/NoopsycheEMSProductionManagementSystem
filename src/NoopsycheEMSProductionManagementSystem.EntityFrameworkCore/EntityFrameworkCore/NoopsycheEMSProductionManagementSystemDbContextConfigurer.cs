using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace NoopsycheEMSProductionManagementSystem.EntityFrameworkCore
{
    public static class NoopsycheEMSProductionManagementSystemDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<NoopsycheEMSProductionManagementSystemDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<NoopsycheEMSProductionManagementSystemDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
