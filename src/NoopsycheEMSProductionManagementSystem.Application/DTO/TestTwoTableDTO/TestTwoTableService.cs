using Abp.Application.Services;
using Abp.Domain.Repositories;
using NoopsycheEMSProductionManagementSystem.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoopsycheEMSProductionManagementSystem.DTO.TestTwoTableDTO
{
    public class TestTwoTableService : CrudAppService<TestTwoTable, TestTwoTableAPJDTO, int, TestTwoTablePageDTO, TestTwoTableCreateDTO>
    {

        private IRepository<TestTwoTable, int> _repository;
        public TestTwoTableService(IRepository<TestTwoTable, int> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}

