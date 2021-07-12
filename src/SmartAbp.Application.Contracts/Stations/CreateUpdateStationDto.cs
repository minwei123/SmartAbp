using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace SmartAbp.Stations
{
    public class CreateUpdateStationDto : AuditedEntityDto<Guid>
    {
        [Required]
        [StringLength(128)]
        public String Name { get; set; }
        [Required]
        [StringLength(128)]
        public String Description { get; set; }
        [Required]
        [StringLength(128)]
        public String Remarks { get; set; }
        [Required]
        [StringLength(128)]
        public String CreatedDT { get; set; }
        [Required]
        [StringLength(128)]
        public String ModifiedDT { get; set; }
        [Required]
        [StringLength(128)]
        public String DeletedDT { get; set; }
        [Required]
        [StringLength(128)]
        public String IsEnabled { get; set; }
        [Required]
        [StringLength(128)]
        public String IsDeleted { get; set; }
        [Required]
        [StringLength(128)]
        public String LinePK { get; set; }
        [Required]
        [StringLength(128)]
        public String LineID { get; set; }
        [Required]
        [StringLength(128)]
        public String SkillScore { get; set; }
    }
}
