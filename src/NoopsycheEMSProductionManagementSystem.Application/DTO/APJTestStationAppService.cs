using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using NoopsycheEMSProductionManagementSystem.DTO.TestStationDTO;
using NoopsycheEMSProductionManagementSystem.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoopsycheEMSProductionManagementSystem.DTO
{
    public class APJTestStationAppService : CrudAppService<TestStation, APJTestStationDto, int, PagedAPJTestStationDto, CreateAPJTestStationDto>, IAPJTestStationAppService
    {
        private IRepository<TestStation, int> _TestStationrepository;
        //APJTestStationAppService 解释: 1. 通过构造函数注入 2. 通过base(repository)将repository传递给父类
        public APJTestStationAppService(IRepository<TestStation, int> repository) : base(repository)
        {
            _TestStationrepository = repository;
        }
        //TestGetQuerycondition 解释: 1. 通过Get请求获取前端传递的参数 2. 通过Where方法进行查询 3. 返回查询结果
        [HttpGet]
        public async Task<dynamic> TestGetQuerycondition(string? testStationCoding, string? testStationName)
        {
            var query = await _TestStationrepository.GetAllListAsync();

            //var show;

            if (!string.IsNullOrEmpty(testStationCoding))
            {
                query = query.Where(x => x.TestStationCoding.Contains(testStationCoding)).ToList();
            }

            if (!string.IsNullOrEmpty(testStationName))
            {
                query = query.Where(x => x.TestStationName.Contains(testStationName)).ToList();
            }

            return query;
        }

        TestStationWDDTO ICrudAppService<TestStationWDDTO, int, PagedAPJTestStationDto, CreateAPJTestStationDto, CreateAPJTestStationDto, EntityDto<int>, EntityDto<int>>.Create(CreateAPJTestStationDto input)
        {
            throw new NotImplementedException();
        }

        TestStationWDDTO ICrudAppService<TestStationWDDTO, int, PagedAPJTestStationDto, CreateAPJTestStationDto, CreateAPJTestStationDto, EntityDto<int>, EntityDto<int>>.Get(EntityDto<int> input)
        {
            throw new NotImplementedException();
        }

        PagedResultDto<TestStationWDDTO> ICrudAppService<TestStationWDDTO, int, PagedAPJTestStationDto, CreateAPJTestStationDto, CreateAPJTestStationDto, EntityDto<int>, EntityDto<int>>.GetAll(PagedAPJTestStationDto input)
        {
            throw new NotImplementedException();
        }

        TestStationWDDTO ICrudAppService<TestStationWDDTO, int, PagedAPJTestStationDto, CreateAPJTestStationDto, CreateAPJTestStationDto, EntityDto<int>, EntityDto<int>>.Update(CreateAPJTestStationDto input)
        {
            throw new NotImplementedException();
        }
    }
}
