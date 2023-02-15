using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using NoopsycheEMSProductionManagementSystem.Table;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoopsycheEMSProductionManagementSystem.DTO.ElectricalMachineryTableDTO
{
    [AutoMapTo(typeof(ElectricalMachineryTable))]
    public class ElectricalMachineryTableAPJDTOCreate : IEntityDto<int>
    {
        [Required]
        public int Id { get; set; }
        /// <summary>
        /// 电机表机器人序列号
        /// </summary>
        [Required]
        public string ElectricalMachineryTableRobotnumber { get; set; }
        /// <summary>
        /// 电机表作业号
        /// </summary>
        [Required]
        public string ElectricalMachineryTableJobNumber { get; set; }
        /// <summary>
        /// 电机表轴
        /// </summary>
        [Required]
        public int ElectricalMachineryTableAxle { get; set; }
        /// <summary>
        /// 电机表型号
        /// </summary>
        [Required]
        public string ElectricalMachineryTableNumModel { get; set; }
        /// <summary>
        /// 电机表扫描条码
        /// </summary>
        [Required]
        public string ElectricalMachineryTableScanTheBarcode { get; set; }
        /// <summary>
        /// 电机表描述
        /// </summary>
        [Required]
        public string ElectricalMachineryTableDescribe { get; set; }
        /// <summary>
        /// 电机表物料编码
        /// </summary>
        [Required]
        public string ElectricalMachineryTableMaterialCode { get; set; }
        /// <summary>
        /// 电机表物料描述
        /// </summary>
        [Required]
        public string ElectricalMachineryTableMaterialDescription { get; set; }
        /// <summary>
        /// 电机表序列号
        /// </summary>
        [Required]
        public string ElectricalMachineryTableSerialNumber { get; set; }
        /// <summary>
        /// 电机表装配工
        /// </summary>
        [Required]
        public string ElectricalMachineryTableAssembler { get; set; }
        /// <summary>
        /// 电机表日期
        /// </summary>
        [Required]
        public DateTime ElectricalMachineryTableDateTime { get; set; }
    }
}
