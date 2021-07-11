using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace SmartAbp.Stations
{
    public class RobotAppService :
        CrudAppService<
            Robot, //The Book entity
            RobotDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto,
            CreateUpdateRobotDto>,
        IRobotAppService
    {
        public RobotAppService(IRepository<Robot, Guid> repository)
            : base(repository)
        {
        }
    }
}