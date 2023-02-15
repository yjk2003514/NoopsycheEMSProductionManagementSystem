using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoopsycheEMSProductionManagementSystem.DTO.TestTwoTableDTO
{
    public class TestTwoTableMateDTO : EntityDto
    {
        public string? TestTwoTableNumber { get; set; }
        /// <summary>
        /// 测试工位二表型号
        /// </summary>
        public string? TestTwoTableModelNum { get; set; }
        /// <summary>
        /// 测试工位二表绝缘检查
        /// </summary>
        public string? TestTwoTableInsulationInspection { get; set; }
        /// <summary>
        /// 测试工位二表作业号
        /// </summary>
        public string? TestTwoTableJobNumber { get; set; }
        /// <summary>
        /// 测试工位二表调试
        /// </summary>
        public string? TestTwoTableDebugging { get; set; }
        /// <summary>
        /// 测试工位二表跑合
        /// </summary>
        public string? TestTwoTableRunningin { get; set; }
        /// <summary>
        /// 测试工位二表物料编码
        /// </summary>
        public string? TestTwoTableMaterialCode { get; set; }
        /// <summary>
        /// 测试工位二表物料描述
        /// </summary>
        public string? TestTwoTableMaterialDescription { get; set; }
        /// <summary>
        /// 测试工位二表轴
        /// </summary>
        public string? TestTwoTableAxle { get; set; }
        /// <summary>
        /// 测试工位二表理论数量
        /// </summary>
        public string? TestTwoTableTheoreticalQuantity { get; set; }
        /// <summary>
        /// 测试工位二表实际数量
        /// </summary>
        public string? TestTwoTableRealQuantity { get; set; }
    }
}
