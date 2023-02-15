using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoopsycheEMSProductionManagementSystem.DTO.GearCaseTableDTO
{
    public class GearCaseTableAPJDTOPaged:PagedResultRequestDto,IPagedAndSortedResultRequest
    {
        //PagedResultRequestDto 有两个属性，分别是SkipCount和MaxResultCount，分别表示跳过的记录数和最大返回的记录数
        public string Keyword { get; set; }

        public bool? IsActive { get; set; }
        public string Sorting { get; set; }
    }
}
