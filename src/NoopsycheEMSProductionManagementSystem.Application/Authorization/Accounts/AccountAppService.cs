using System.Threading.Tasks;
using Abp.Configuration;
using Abp.Zero.Configuration;
using NoopsycheEMSProductionManagementSystem.Authorization.Accounts.Dto;
using NoopsycheEMSProductionManagementSystem.Authorization.Users;

namespace NoopsycheEMSProductionManagementSystem.Authorization.Accounts
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class AccountAppService : NoopsycheEMSProductionManagementSystemAppServiceBase, IAccountAppService
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    {
        // from: http://regexlib.com/REDetails.aspx?regexp_id=1923
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public const string PasswordRegex = "(?=^.{8,}$)(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\\s)[0-9a-zA-Z!@#$%^&*()]*$";
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

        private readonly UserRegistrationManager _userRegistrationManager;

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public AccountAppService(
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
            UserRegistrationManager userRegistrationManager)
        {
            _userRegistrationManager = userRegistrationManager;
        }

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public async Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input)
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
        {
            var tenant = await TenantManager.FindByTenancyNameAsync(input.TenancyName);
            if (tenant == null)
            {
                return new IsTenantAvailableOutput(TenantAvailabilityState.NotFound);
            }

            if (!tenant.IsActive)
            {
                return new IsTenantAvailableOutput(TenantAvailabilityState.InActive);
            }

            return new IsTenantAvailableOutput(TenantAvailabilityState.Available, tenant.Id);
        }

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public async Task<RegisterOutput> Register(RegisterInput input)
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
        {
            var user = await _userRegistrationManager.RegisterAsync(
                input.Name,
                input.Surname,
                input.EmailAddress,
                input.UserName,
                input.Password,
                true // Assumed email address is always confirmed. Change this if you want to implement email confirmation.
            );

            var isEmailConfirmationRequiredForLogin = await SettingManager.GetSettingValueAsync<bool>(AbpZeroSettingNames.UserManagement.IsEmailConfirmationRequiredForLogin);

            return new RegisterOutput
            {
                CanLogin = user.IsActive && (user.IsEmailConfirmed || !isEmailConfirmationRequiredForLogin)
            };
        }
    }
}
