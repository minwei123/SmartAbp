using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;


namespace SmartAbp.Stations
{
    public class RobotDto : AuditedEntityDto<Guid>
    {
        RobotType robotType { get; set; }
        public List<WeldSectionDto> weldSections { get; set; }

    }
}

