using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoopsycheEMSProductionManagementSystem.DTO.ElectricalMachineryTableDTO
{
    public class ElectricalMachineryTableAPJDTOPaged : PagedResultRequestDto,IPagedAndSortedResultRequest
    {
        public string Keyword { get; set; }
        public bool? IsActive { get; set; }
        public string Sorting { get; set; }
    }
}
