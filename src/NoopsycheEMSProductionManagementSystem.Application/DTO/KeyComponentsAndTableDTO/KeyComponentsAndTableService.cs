using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using NoopsycheEMSProductionManagementSystem.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoopsycheEMSProductionManagementSystem.DTO.KeyComponentsAndTableDTO
{
    public class KeyComponentsAndTableService : CrudAppService<KeyComponentsAndTable, KeyComponentsAndTableAPJDTO, int, KeyComponentsAndTableAPJDTOPaged, KeyComponentsAndTableAPJDTOCreate>
    {
        private IRepository<KeyComponentsAndTable, int> _repository;
        public KeyComponentsAndTableService(IRepository<KeyComponentsAndTable, int> repository) : base(repository)
        {
            _repository = repository;
        }

        
    }
}
