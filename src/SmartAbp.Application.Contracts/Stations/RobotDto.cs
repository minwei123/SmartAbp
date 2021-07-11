using System;
using Volo.Abp.Application.Dtos;


namespace SmartAbp.Stations
{
    public class RobotDto : AuditedEntityDto<Guid>
    {
        RobotType robotType { get; set; }
    }
}

