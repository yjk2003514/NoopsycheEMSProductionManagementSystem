using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization.Users;
using Abp.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using NoopsycheEMSProductionManagementSystem.DTO.WDTO;
using NoopsycheEMSProductionManagementSystem.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoopsycheEMSProductionManagementSystem.DTO
{

    public class APJUserAppService : AsyncCrudAppService<MaterialAllocationTable, APJUserDto, int, PagedAPJUserResultRequestDto, CreateAPJUserDto>, IAPJUserAppService
    {
        private IRepository<MaterialAllocationTable, int> _repository;
        //APJUserAppService 解释: 1.继承AsyncCrudAppService<MaterialAllocationTable, APJUserDto, int, PagedAPJUserResultRequestDto, CreateAPJUserDto> 2.实现IAPJUserAppService接口
        public APJUserAppService(IRepository<MaterialAllocationTable, int> repository): base(repository)
        {
            _repository = repository;
        }

        //GetQuerycondition 解释: 1.返回值为Task<dynamic> 2.参数为string? materialAllocationTableCoding, string? materialAllocationTableDescribe
        [HttpGet]
        public async Task<dynamic> GetQuerycondition(string ?materialAllocationTableCoding,string? materialAllocationTableDescribe)
        {
            var query = await _repository.GetAllListAsync();

            //var show;
            
            if (!string.IsNullOrEmpty(materialAllocationTableCoding))
            {
                query = query.Where(x => x.MaterialAllocationTableCoding.Contains(materialAllocationTableCoding)).ToList();
            }

            if (!string.IsNullOrEmpty(materialAllocationTableDescribe))
            {
                query = query.Where(x => x.MaterialAllocationTableTab.Contains(materialAllocationTableDescribe)).ToList();
            }

            return query;
        }

        Task<MaterialAllocationTableDTO> IAsyncCrudAppService<MaterialAllocationTableDTO, int, PagedAPJUserResultRequestDto, CreateAPJUserDto, CreateAPJUserDto, EntityDto<int>, EntityDto<int>>.CreateAsync(CreateAPJUserDto input)
        {
            throw new NotImplementedException();
        }

        Task<PagedResultDto<MaterialAllocationTableDTO>> IAsyncCrudAppService<MaterialAllocationTableDTO, int, PagedAPJUserResultRequestDto, CreateAPJUserDto, CreateAPJUserDto, EntityDto<int>, EntityDto<int>>.GetAllAsync(PagedAPJUserResultRequestDto input)
        {
            throw new NotImplementedException();
        }

        Task<MaterialAllocationTableDTO> IAsyncCrudAppService<MaterialAllocationTableDTO, int, PagedAPJUserResultRequestDto, CreateAPJUserDto, CreateAPJUserDto, EntityDto<int>, EntityDto<int>>.GetAsync(EntityDto<int> input)
        {
            throw new NotImplementedException();
        }

        Task<MaterialAllocationTableDTO> IAsyncCrudAppService<MaterialAllocationTableDTO, int, PagedAPJUserResultRequestDto, CreateAPJUserDto, CreateAPJUserDto, EntityDto<int>, EntityDto<int>>.UpdateAsync(CreateAPJUserDto input)
        {
            throw new NotImplementedException();
        }
    }
}
