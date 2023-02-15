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
    /// 测试工位表BS
    /// </summary>
    [Table("TestStation")]
    public class TestStation :Entity<int>
    {
        /// <summary>
        /// 测试工位id自增
        /// </summary>
        [Key]
        [Column("Id")]
        public override int Id { get; set; }
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
