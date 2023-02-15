using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoopsycheEMSProductionManagementSystem.DTO;
using NoopsycheEMSProductionManagementSystem.Table;

namespace NoopsycheEMSProductionManagementSystem.DTO.GearCaseTableDTO
{
    public interface IGearCaseTableService : ICrudAppService<GearCaseTableAPJDTO, int, GearCaseTableAPJDTOPaged, GearCaseTableAPJDTOCreate>
      {

      }
}