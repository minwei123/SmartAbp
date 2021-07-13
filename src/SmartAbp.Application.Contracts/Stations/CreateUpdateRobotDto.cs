using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace SmartAbp.Stations
{
    public class CreateUpdateRobotDto : AuditedEntityDto<Guid>
    {
        [Required]
        RobotType robotType { get; set; }
        [Required]
        public List<WeldSectionDto> weldSections { get; set; }

    }
}
