using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using NoopsycheEMSProductionManagementSystem.Table;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoopsycheEMSProductionManagementSystem.DTO.TestStationDTO
{
    [AutoMapFrom(typeof(TestStation))]
    public class APJTestStationDto : EntityDto
    {
        
        [Column("Id")]
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
