using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
namespace SmartAbp.Stations
{
    public interface IRobotAppService :
            ICrudAppService< 
            RobotDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateRobotDto> 
    {
    }
}
