using Abp.Application.Services;
using NoopsycheEMSProductionManagementSystem.DTO.TestStationDTO;
using NoopsycheEMSProductionManagementSystem.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoopsycheEMSProductionManagementSystem.DTO
{
    //IAPJTestStationAppService 解释: 1.继承ICrudAppService<TestStationWDDTO, int, PagedAPJTestStationDto, CreateAPJTestStationDto> 2.接口
    public interface IAPJTestStationAppService : ICrudAppService<TestStationWDDTO,  int, PagedAPJTestStationDto, CreateAPJTestStationDto>
    {
        public Task<dynamic> TestGetQuerycondition(string? testStationCoding, string? testStationName);
    }
}
 