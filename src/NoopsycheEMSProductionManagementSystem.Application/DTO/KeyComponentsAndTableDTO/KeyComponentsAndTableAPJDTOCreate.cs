using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using NoopsycheEMSProductionManagementSystem.Table;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoopsycheEMSProductionManagementSystem.DTO.KeyComponentsAndTableDTO
{
    [AutoMapTo(typeof(KeyComponentsAndTable))]
    public class KeyComponentsAndTableAPJDTOCreate : IEntityDto<int>
    {
        public int Id { get; set; }
        /// <summary>
        /// 关键键采集机器人序列号
        /// </summary>
        [Required]
        public string KeyComponentsAndTableRobotnumber { get; set; }
        /// <summary>
        /// 关键键采集非标作业号
        /// </summary>
        [Required]
        public string KeyComponentsAndTableNonStandardNumber { get; set; }
        /// <summary>
        /// 关键键采集扫描条码
        /// </summary>
        [Required]
        public string KeyComponentsAndTableScanTheBarcode { get; set; }
        /// <summary>
        /// 关键键采集作业号
        /// </summary>
        [Required]
        public string KeyComponentsAndTableJobNumber { get; set; }
        /// <summary>
        /// 关键键采集轴
        /// </summary>
        [Required]
        public int KeyComponentsAndTableAxle { get; set; }
        /// <summary>
        /// 关键键采集型号
        /// </summary>
        [Required]
        public string KeyComponentsAndTableNumModel { get; set; }
        /// <summary>
        /// 关键键采集序列号
        /// </summary>
        [Required]
        public string KeyComponentsAndTableNumber { get; set; }
        /// <summary>
        /// 关键键采集描述
        /// </summary>
        [Required]
        public string KeyComponentsAndTableDescribe { get; set; }
        /// <summary>
        /// 关键键采集物料编码
        /// </summary>
        [Required]
        public string KeyComponentsAndTableMaterialCode { get; set; }
        /// <summary>
        /// 关键键采集物料描述
        /// </summary>
        [Required]
        public string KeyComponentsAndTableMaterialDescription { get; set; }
        /// <summary>
        /// 关键键采集装配工
        /// </summary>
        [Required]
        public string KeyComponentsAndTableAssembler { get; set; }
        /// <summary>
        /// 关键键采集日期
        /// </summary>
        public DateTime KeyComponentsAndTableDateTime { get; set; } = DateTime.Now;
    }
}
