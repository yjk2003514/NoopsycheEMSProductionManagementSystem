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
/// 测试工位一表
/// </summary>
    [Table("TestOneTable")]
    public class TestOneTable : Entity<int>
    {
        /// <summary>
        /// 测试工位id自增
        /// </summary>
        [Column("Id")]
        [Key]
        public override int Id { get; set; }
        /// <summary>
        /// 测试工位一表机器人序列号
        /// </summary>
        public string? TestOneTableNumber { get; set; }
        /// <summary>
        /// 测试工位一表作业号
        /// </summary>
        public string? TestOneTableJobNumber { get; set; }
        /// <summary>
        /// 测试工位一型号
        /// </summary>
        public string? TestOneTableModelNum { get; set; }
        /// <summary>
        /// 零位测试工位
        /// </summary>
        public string? TestOneTableZero { get; set; }
        /// <summary>
        /// 定位精度测试工位
        /// </summary>
        public string? TestOneTableLocation { get; set; }
        /// <summary>
        /// A1轴
        /// </summary>
        public string? TestOneTableA1Axlea { get; set; }
        /// <summary>
        /// A2轴
        /// </summary>
        public string? TestOneTableA2Axleb { get; set; }
        /// <summary>
        /// A3轴
        /// </summary>
        public string? TestOneTableA3Axlec { get; set; }
        /// <summary>
        /// A4轴
        /// </summary>
        public string? TestOneTableA4Axld { get; set; }
        /// <summary>
        /// A5轴
        /// </summary>
        public string? TestOneTableA5Axlee { get; set; }
        /// <summary>
        /// A6轴
        /// </summary>
        public string? TestOneTableA6Axlef { get; set; }

    }
}
