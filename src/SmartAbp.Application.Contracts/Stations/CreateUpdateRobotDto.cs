using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace SmartAbp.Stations
{
    public class CreateUpdateRobotDto : AuditedEntityDto<Guid>
    {
        [Required]
        RobotType robotType { get; set; }
    }
}
