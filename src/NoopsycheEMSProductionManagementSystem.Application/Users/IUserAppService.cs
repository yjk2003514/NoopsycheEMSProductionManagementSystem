using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using NoopsycheEMSProductionManagementSystem.Roles.Dto;
using NoopsycheEMSProductionManagementSystem.Users.Dto;

namespace NoopsycheEMSProductionManagementSystem.Users
{
#pragma warning disable CS1591 // ȱ�ٶԹ����ɼ����ͻ��Ա�� XML ע��
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
#pragma warning restore CS1591 // ȱ�ٶԹ����ɼ����ͻ��Ա�� XML ע��
    {
#pragma warning disable CS1591 // ȱ�ٶԹ����ɼ����ͻ��Ա�� XML ע��
        Task DeActivate(EntityDto<long> user);
#pragma warning restore CS1591 // ȱ�ٶԹ����ɼ����ͻ��Ա�� XML ע��
#pragma warning disable CS1591 // ȱ�ٶԹ����ɼ����ͻ��Ա�� XML ע��
        Task Activate(EntityDto<long> user);
#pragma warning restore CS1591 // ȱ�ٶԹ����ɼ����ͻ��Ա�� XML ע��
#pragma warning disable CS1591 // ȱ�ٶԹ����ɼ����ͻ��Ա�� XML ע��
        Task<ListResultDto<RoleDto>> GetRoles();
#pragma warning restore CS1591 // ȱ�ٶԹ����ɼ����ͻ��Ա�� XML ע��
#pragma warning disable CS1591 // ȱ�ٶԹ����ɼ����ͻ��Ա�� XML ע��
        Task ChangeLanguage(ChangeUserLanguageDto input);
#pragma warning restore CS1591 // ȱ�ٶԹ����ɼ����ͻ��Ա�� XML ע��

#pragma warning disable CS1591 // ȱ�ٶԹ����ɼ����ͻ��Ա�� XML ע��
        Task<bool> ChangePassword(ChangePasswordDto input);
#pragma warning restore CS1591 // ȱ�ٶԹ����ɼ����ͻ��Ա�� XML ע��
    }
}
