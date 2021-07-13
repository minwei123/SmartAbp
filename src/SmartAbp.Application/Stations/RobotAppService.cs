using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartAbp.Books;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartAbp.Books;
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
        private readonly IRepository<Robot, Guid> _repository;
        public RobotAppService(IRepository<Robot, Guid> repository)
            : base(repository)
        {
            _repository = repository;
        }

        

        //重载关联查询
        public override async Task<PagedResultDto<RobotDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            var robots = new List<Robot>(await _repository.WithDetailsAsync(x => x.weldSections));
            var robotcount = await _repository.GetCountAsync();
            
            var robotDtos = robots.Select(x =>
            {
                var robotDto = ObjectMapper.Map<Robot, RobotDto>(x);
                robotDto.weldSections = ObjectMapper.Map<List<WeldSection>, List<WeldSectionDto>>(x.weldSections);
                return robotDto;
            }).ToList();

            
            var totalCount = await Repository.GetCountAsync();
            return new PagedResultDto<RobotDto>(robotcount, robotDtos);


        }


    }
}