using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using NoopsycheEMSProductionManagementSystem.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoopsycheEMSProductionManagementSystem.DTO.TestStationDTO
{
    [AutoMapTo(typeof(TestStation))]
    public class CreateAPJTestStationDto : IEntityDto<int>
    {
        /// <summary>
        /// 测试工位id自增
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 测试工位编码
        /// </summary>
        public string TestStationCoding { get; set; }
        /// <summary>
        /// 测试工位名称
        /// </summary>
        public string TestStationName { get; set; }
    }
}
