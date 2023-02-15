using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoopsycheEMSProductionManagementSystem.Table
{/// <summary>
/// 测试工位二表
/// </summary>
    [Table("TestTwoTable")]
    public class TestTwoTable : Entity<int>
    {/// <summary>
     /// 测试工位id自增
     /// </summary>
        [Column("Id")]
        [Key]
        public override int Id { get; set; }
        /// <summary>
        /// 测试工位二表机器人序列号
        /// </summary>
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
