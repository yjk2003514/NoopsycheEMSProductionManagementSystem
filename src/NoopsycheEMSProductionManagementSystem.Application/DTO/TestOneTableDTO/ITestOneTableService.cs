using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoopsycheEMSProductionManagementSystem.DTO.TestOneTableDTO
{
    public interface ITestOneTableService : ICrudAppService<TestOneTableMateDto,int, TestOneTablePageDto, TestOneTableCreateDto>
    {
        
    }
}
