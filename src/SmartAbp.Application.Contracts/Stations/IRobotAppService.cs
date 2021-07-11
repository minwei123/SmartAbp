using System;
using Volo.Abp.Application.Dtos;
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
