using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using NoopsycheEMSProductionManagementSystem.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoopsycheEMSProductionManagementSystem.DTO.ElectricalMachineryTableDTO
{
    [AutoMapFrom(typeof(ElectricalMachineryTable))]
    public class ElectricalMachineryTableAPJDTOMate: EntityDto
    {
        /// <summary>
        /// 电机表机器人序列号
        /// </summary>
        public string? ElectricalMachineryTableRobotnumber { get; set; }
        /// <summary>
        /// 电机表作业号
        /// </summary>
        public string? ElectricalMachineryTableJobNumber { get; set; }
        /// <summary>
        /// 电机表轴
        /// </summary>
        public int ElectricalMachineryTableAxle { get; set; }
        /// <summary>
        /// 电机表型号
        /// </summary>
        public string? ElectricalMachineryTableNumModel { get; set; }
        /// <summary>
        /// 电机表扫描条码
        /// </summary>
        public string? ElectricalMachineryTableScanTheBarcode { get; set; }
        /// <summary>
        /// 电机表描述
        /// </summary>
        public string? ElectricalMachineryTableDescribe { get; set; }
        /// <summary>
        /// 电机表物料编码
        /// </summary>
        public string? ElectricalMachineryTableMaterialCode { get; set; }
        /// <summary>
        /// 电机表物料描述
        /// </summary>
        public string? ElectricalMachineryTableMaterialDescription { get; set; }
        /// <summary>
        /// 电机表序列号
        /// </summary>
        public string? ElectricalMachineryTableSerialNumber { get; set; }
        /// <summary>
        /// 电机表装配工
        /// </summary>
        public string? ElectricalMachineryTableAssembler { get; set; }
        /// <summary>
        /// 电机表日期
        /// </summary>
        public DateTime ElectricalMachineryTableDateTime { get; set; }
    }
}
