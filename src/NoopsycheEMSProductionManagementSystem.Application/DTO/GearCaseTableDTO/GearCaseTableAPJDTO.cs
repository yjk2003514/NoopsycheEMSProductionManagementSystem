using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using NoopsycheEMSProductionManagementSystem.Table;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoopsycheEMSProductionManagementSystem.DTO.GearCaseTableDTO
{
    [AutoMapFrom(typeof(GearCaseTable))]

    public class GearCaseTableAPJDTO : EntityDto
    {

        public string? GearCaseTableRobotnumber { get; set; }
        /// <summary>
        /// 齿轮箱表作业号
        /// </summary>
        public string? GearCaseTableJobNumber { get; set; }
        /// <summary>
        /// 齿轮箱表轴
        /// </summary>
        public int GearCaseTableAxle { get; set; }
        /// <summary>
        /// 齿轮箱表型号
        /// </summary>
        public string? GearCaseTableNumModel { get; set; }
        /// <summary>
        /// 齿轮箱表扫描条码
        /// </summary>
        public string? GearCaseTableScanTheBarcode { get; set; }
        /// <summary>
        /// 齿轮箱表描述
        /// </summary>
        public string? GearCaseTableDescribe { get; set; }
        /// <summary>
        /// 齿轮箱表物料编码
        /// </summary>
        public string? GearCaseTableMaterialCode { get; set; }
        /// <summary>
        /// 齿轮箱表物料描述
        /// </summary>
        public string? GearCaseTableMaterialDescription { get; set; }
        /// <summary>
        /// 齿轮箱表序列号
        /// </summary>
        public string? GearCaseTableSerialNumber { get; set; }
        /// <summary>
        /// 齿轮箱表装配工
        /// </summary>
        public string? GearCaseTableWorker { get; set; }
        /// <summary>
        /// 齿轮箱表装配时间
        /// </summary>
        public DateTime? GearCaseTableTime { get; set; }
        /// <summary>
        /// 齿轮箱表注油标准值
        /// </summary>
        public string? GearCaseTableFillingStandard { get; set; }
        /// <summary>
        /// 齿轮箱表注油实际值
        /// </summary>
        public string? GearCaseTableActualValueOfOilInjection { get; set; }
        /// <summary>
        /// 齿轮箱表偏差值
        /// </summary>
        public string? GearCaseTableDeviationValue { get; set; }
        /// <summary>
        /// 齿轮箱表上传结果
        /// </summary>
        public string? GearCaseTableUploadResults { get; set; }
    }
}
