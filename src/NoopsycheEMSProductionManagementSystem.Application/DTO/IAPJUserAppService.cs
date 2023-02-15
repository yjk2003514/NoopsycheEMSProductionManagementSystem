using Abp.Application.Services;
using NoopsycheEMSProductionManagementSystem.DTO.WDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoopsycheEMSProductionManagementSystem.DTO
{
    //IAPJUserAppService 解释: 1.继承IAsyncCrudAppService<MaterialAllocationTableDTO, int, PagedAPJUserResultRequestDto, CreateAPJUserDto> 2.接口
    public interface IAPJUserAppService : IAsyncCrudAppService<MaterialAllocationTableDTO, int, PagedAPJUserResultRequestDto, CreateAPJUserDto>
    {
        public Task<dynamic> GetQuerycondition(string? materialAllocationTableCoding, string? materialAllocationTableDescribe);
    }

}
