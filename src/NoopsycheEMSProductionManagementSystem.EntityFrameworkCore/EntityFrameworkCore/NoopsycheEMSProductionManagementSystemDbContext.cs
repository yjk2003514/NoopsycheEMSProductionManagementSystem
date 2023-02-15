using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using NoopsycheEMSProductionManagementSystem.Authorization.Roles;
using NoopsycheEMSProductionManagementSystem.Authorization.Users;
using NoopsycheEMSProductionManagementSystem.MultiTenancy;
using NoopsycheEMSProductionManagementSystem.Table;

namespace NoopsycheEMSProductionManagementSystem.EntityFrameworkCore
{
    //NoopsycheEMSProductionManagementSystemDbContext 解释: 1.继承AbpZeroDbContext<Tenant, Role, User, NoopsycheEMSProductionManagementSystemDbContext> 2.数据库上下文
    public class NoopsycheEMSProductionManagementSystemDbContext : AbpZeroDbContext<Tenant, Role, User, NoopsycheEMSProductionManagementSystemDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public NoopsycheEMSProductionManagementSystemDbContext(DbContextOptions<NoopsycheEMSProductionManagementSystemDbContext> options) : base(options)
        {
            
        }
        public DbSet<ZSGGC> ZSGGC { get; set; }
        public DbSet<MaterialAllocationTable> MaterialAllocationTable { get; set; }
        public DbSet<TestStation> TestStation { get; set; }
        public DbSet<KeyComponentsAndTable> KeyComponentsAndTable { get; set; }
        public DbSet<ElectricalMachineryTable> ElectricalMachineryTable { get; set; }
        public DbSet<GearCaseTable> GearCaseTable { get; set; }
        public DbSet<TestOneTable> TestOneTable { get; set; }
        public DbSet<TestTwoTable> TestTwoTable { get; set; }
    }
}

