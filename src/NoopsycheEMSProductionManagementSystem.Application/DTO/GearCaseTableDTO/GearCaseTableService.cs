using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using NoopsycheEMSProductionManagementSystem.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoopsycheEMSProductionManagementSystem.DTO.GearCaseTableDTO
{
    public class GearCaseTableService : CrudAppService<GearCaseTable, GearCaseTableAPJDTO,int, GearCaseTableAPJDTOPaged, GearCaseTableAPJDTOCreate>, IGearCaseTableService
    {
       
        private IRepository<GearCaseTable, int> _repository;
        public GearCaseTableService(IRepository<GearCaseTable, int> repository) : base(repository)
        {
            _repository = repository;
        }

      
    }
}
