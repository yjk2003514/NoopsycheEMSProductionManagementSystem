using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using NoopsycheEMSProductionManagementSystem.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoopsycheEMSProductionManagementSystem.DTO.ElectricalMachineryTableDTO
{
    public class ElectricalMachineryTableService : CrudAppService<ElectricalMachineryTable, ElectricalMachineryTableAPJDTO, int, ElectricalMachineryTableAPJDTOPaged, ElectricalMachineryTableAPJDTOCreate>
    {
        private IRepository<ElectricalMachineryTable, int> _repository;
        public ElectricalMachineryTableService(IRepository<ElectricalMachineryTable, int> repository) : base(repository)
        {
            _repository = repository;
        }

       
    }
}
