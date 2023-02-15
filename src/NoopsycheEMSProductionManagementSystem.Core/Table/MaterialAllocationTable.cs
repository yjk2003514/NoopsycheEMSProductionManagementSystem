using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoopsycheEMSProductionManagementSystem.Table
{   
    /// <summary>
    /// 物料配置表
    /// </summary>
    [Table("MaterialAllocationTable")]
    public class MaterialAllocationTable:Entity<int>
    {
        /// <summary>
        /// 物料配置id
        /// </summary>
        [Key]
        [Column("Id")]
        public override int Id { get; set; }
        /// <summary>
        /// 物料配置描述
        /// </summary>
        public string? MaterialAllocationTableDescribe { get; set; }
        /// <summary>
        /// 物料配置编码
        /// </summary>
        public string? MaterialAllocationTableCoding { get; set; }
        /// <summary>
        /// 物料配置页签
        /// </summary>
        public string? MaterialAllocationTableTab { get; set; }
        /// <summary>
        /// 物料配置轴
        /// </summary>
        public int MaterialAllocationTableAxle { get; set; }
        /// <summary>
        /// 物料配置注油标准值
        /// </summary>
        public string? MaterialAllocationTableStandard { get; set; }
        /// <summary>
        /// 物料配置注油偏差值
        /// </summary>
        public string? MaterialAllocationTableDeviation { get; set; }

    }
}
