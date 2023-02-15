using AutoMapper;
using NoopsycheEMSProductionManagementSystem.Authorization.Users;

namespace NoopsycheEMSProductionManagementSystem.Users.Dto
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class UserMapProfile : Profile
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    {
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public UserMapProfile()
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
        {
            CreateMap<UserDto, User>();
            CreateMap<UserDto, User>()
                .ForMember(x => x.Roles, opt => opt.Ignore())
                .ForMember(x => x.CreationTime, opt => opt.Ignore());

            CreateMap<CreateUserDto, User>();
            CreateMap<CreateUserDto, User>().ForMember(x => x.Roles, opt => opt.Ignore());
        }
    }
}
