﻿using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.IdentityFramework;
using Abp.Linq.Extensions;
using Abp.MultiTenancy;
using Abp.Runtime.Security;
using NoopsycheEMSProductionManagementSystem.Authorization;
using NoopsycheEMSProductionManagementSystem.Authorization.Roles;
using NoopsycheEMSProductionManagementSystem.Authorization.Users;
using NoopsycheEMSProductionManagementSystem.Editions;
using NoopsycheEMSProductionManagementSystem.MultiTenancy.Dto;
using Microsoft.AspNetCore.Identity;

namespace NoopsycheEMSProductionManagementSystem.MultiTenancy
{
    [AbpAuthorize(PermissionNames.Pages_Tenants)]
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class TenantAppService : AsyncCrudAppService<Tenant, TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>, ITenantAppService
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    {
        private readonly TenantManager _tenantManager;
        private readonly EditionManager _editionManager;
        private readonly UserManager _userManager;
        private readonly RoleManager _roleManager;
        private readonly IAbpZeroDbMigrator _abpZeroDbMigrator;

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public TenantAppService(
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
            IRepository<Tenant, int> repository,
            TenantManager tenantManager,
            EditionManager editionManager,
            UserManager userManager,
            RoleManager roleManager,
            IAbpZeroDbMigrator abpZeroDbMigrator)
            : base(repository)
        {
            _tenantManager = tenantManager;
            _editionManager = editionManager;
            _userManager = userManager;
            _roleManager = roleManager;
            _abpZeroDbMigrator = abpZeroDbMigrator;
        }

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public override async Task<TenantDto> CreateAsync(CreateTenantDto input)
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
        {
            CheckCreatePermission();

            // Create tenant
            var tenant = ObjectMapper.Map<Tenant>(input);
            tenant.ConnectionString = input.ConnectionString.IsNullOrEmpty()
                ? null
                : SimpleStringCipher.Instance.Encrypt(input.ConnectionString);

            var defaultEdition = await _editionManager.FindByNameAsync(EditionManager.DefaultEditionName);
            if (defaultEdition != null)
            {
                tenant.EditionId = defaultEdition.Id;
            }

            await _tenantManager.CreateAsync(tenant);
            await CurrentUnitOfWork.SaveChangesAsync(); // To get new tenant's id.

            // Create tenant database
            _abpZeroDbMigrator.CreateOrMigrateForTenant(tenant);

            // We are working entities of new tenant, so changing tenant filter
            using (CurrentUnitOfWork.SetTenantId(tenant.Id))
            {
                // Create static roles for new tenant
                CheckErrors(await _roleManager.CreateStaticRoles(tenant.Id));

                await CurrentUnitOfWork.SaveChangesAsync(); // To get static role ids

                // Grant all permissions to admin role
                var adminRole = _roleManager.Roles.Single(r => r.Name == StaticRoleNames.Tenants.Admin);
                await _roleManager.GrantAllPermissionsAsync(adminRole);

                // Create admin user for the tenant
                var adminUser = User.CreateTenantAdminUser(tenant.Id, input.AdminEmailAddress);
                await _userManager.InitializeOptionsAsync(tenant.Id);
                CheckErrors(await _userManager.CreateAsync(adminUser, User.DefaultPassword));
                await CurrentUnitOfWork.SaveChangesAsync(); // To get admin user's id

                // Assign admin user to role!
                CheckErrors(await _userManager.AddToRoleAsync(adminUser, adminRole.Name));
                await CurrentUnitOfWork.SaveChangesAsync();
            }

            return MapToEntityDto(tenant);
        }

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        protected override IQueryable<Tenant> CreateFilteredQuery(PagedTenantResultRequestDto input)
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
        {
            return Repository.GetAll()
                .WhereIf(!input.Keyword.IsNullOrWhiteSpace(), x => x.TenancyName.Contains(input.Keyword) || x.Name.Contains(input.Keyword))
                .WhereIf(input.IsActive.HasValue, x => x.IsActive == input.IsActive);
        }

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        protected override void MapToEntity(TenantDto updateInput, Tenant entity)
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
        {
            // Manually mapped since TenantDto contains non-editable properties too.
            entity.Name = updateInput.Name;
            entity.TenancyName = updateInput.TenancyName;
            entity.IsActive = updateInput.IsActive;
        }

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public override async Task DeleteAsync(EntityDto<int> input)
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
        {
            CheckDeletePermission();

            var tenant = await _tenantManager.GetByIdAsync(input.Id);
            await _tenantManager.DeleteAsync(tenant);
        }

        private void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

