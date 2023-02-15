using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoopsycheEMSProductionManagementSystem
{
    [Table("ZSGGC")]
    public class ZSGGC :Entity<int>
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }
    }
}
