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
    /// 关键键采集表
    /// </summary>
    [Table("KeyComponentsAndTable")]
    public class KeyComponentsAndTable : Entity<int>
    {
        /// <summary>
        /// 关键键采集id自增
        /// </summary>
        [Key]
        public override int Id { get; set; }
        /// <summary>
        /// 关键键采集机器人序列号
        /// </summary>
        public string KeyComponentsAndTableRobotnumber{ get; set; }
        /// <summary>
        /// 关键键采集非标作业号
        /// </summary>
        public string KeyComponentsAndTableNonStandardNumber { get; set; }
        /// <summary>
        /// 关键键采集扫描条码
        /// </summary>
        public string KeyComponentsAndTableScanTheBarcode { get; set; }
        /// <summary>
        /// 关键键采集作业号
        /// </summary>
        public string KeyComponentsAndTableJobNumber { get; set; }
        /// <summary>
        /// 关键键采集轴
        /// </summary>
        public int KeyComponentsAndTableAxle { get; set; }
        /// <summary>
        /// 关键键采集型号
        /// </summary>
        public string KeyComponentsAndTableNumModel { get; set; }
        /// <summary>
        /// 关键键采集序列号
        /// </summary>
        public string KeyComponentsAndTableNumber { get; set; }
        /// <summary>
        /// 关键键采集描述
        /// </summary>
        public string KeyComponentsAndTableDescribe { get; set; }
        /// <summary>
        /// 关键键采集物料编码
        /// </summary>
        public string KeyComponentsAndTableMaterialCode { get; set; }
        /// <summary>
        /// 关键键采集物料描述
        /// </summary>
        public string KeyComponentsAndTableMaterialDescription { get; set; }
        /// <summary>
        /// 关键键采集装配工
        /// </summary>
        public string KeyComponentsAndTableAssembler { get; set; }
        /// <summary>
        /// 关键键采集日期
        /// </summary>
        public DateTime KeyComponentsAndTableDateTime { get; set; }= DateTime.Now;
     
    }
}
