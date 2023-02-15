using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoopsycheEMSProductionManagementSystem.DTO.KeyComponentsAndTableDTO
{
    public interface IKeyComponentsAndTableService : ICrudAppService<KeyComponentsAndTableAPJDTOMate, int, KeyComponentsAndTableAPJDTOPaged, KeyComponentsAndTableAPJDTOCreate>
    {

    }
}
