using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoopsycheEMSProductionManagementSystem.DTO.ElectricalMachineryTableDTO
{
    public interface IElectricalMachineryTableService : ICrudAppService<ElectricalMachineryTableAPJDTOMate, int, ElectricalMachineryTableAPJDTOPaged, ElectricalMachineryTableAPJDTOCreate>
    {
    }
}
