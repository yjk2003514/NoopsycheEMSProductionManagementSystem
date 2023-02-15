using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Abp.Extensions;

namespace NoopsycheEMSProductionManagementSystem.Identity
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class ExternalLoginInfoHelper
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    {
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public static (string name, string surname) GetNameAndSurnameFromClaims(List<Claim> claims)
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
        {
            string name = null;
            string surname = null;

            var givennameClaim = claims.FirstOrDefault(c => c.Type == ClaimTypes.GivenName);
            if (givennameClaim != null && !givennameClaim.Value.IsNullOrEmpty())
            {
                name = givennameClaim.Value;
            }

            var surnameClaim = claims.FirstOrDefault(c => c.Type == ClaimTypes.Surname);
            if (surnameClaim != null && !surnameClaim.Value.IsNullOrEmpty())
            {
                surname = surnameClaim.Value;
            }

            if (name == null || surname == null)
            {
                var nameClaim = claims.FirstOrDefault(c => c.Type == ClaimTypes.Name);
                if (nameClaim != null)
                {
                    var nameSurName = nameClaim.Value;
                    if (!nameSurName.IsNullOrEmpty())
                    {
                        var lastSpaceIndex = nameSurName.LastIndexOf(' ');
                        if (lastSpaceIndex < 1 || lastSpaceIndex > (nameSurName.Length - 2))
                        {
                            name = surname = nameSurName;
                        }
                        else
                        {
                            name = nameSurName.Substring(0, lastSpaceIndex);
                            surname = nameSurName.Substring(lastSpaceIndex);
                        }
                    }
                }
            }

            return (name, surname);
        }
    }
}
