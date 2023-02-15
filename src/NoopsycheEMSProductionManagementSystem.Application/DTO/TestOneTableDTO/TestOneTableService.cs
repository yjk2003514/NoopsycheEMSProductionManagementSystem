using Abp.Application.Services;
using Abp.Domain.Repositories;
using NoopsycheEMSProductionManagementSystem.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoopsycheEMSProductionManagementSystem.DTO.TestOneTableDTO
{
    public class TestOneTableService: CrudAppService<TestOneTable, TestOneTableAPJDTO,int, TestOneTablePageDto, TestOneTableCreateDto>
    {
        private IRepository<TestOneTable, int> _repository;
        public TestOneTableService(IRepository<TestOneTable, int> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
