using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace SmartAbp.Stations
{
    public class StationAppService:
        CrudAppService<
            Station, //The Book entity
            StationDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateStationDto>, //Used to create/update a book
        IStationAppService
    {
        public StationAppService(IRepository<Station, Guid> repository)
            : base(repository)
        {

        }
    }
    // 操作员在工作站上登录时创建并使用该服务
    public class MatchSkillService // 技能匹配服务
    {
        private ITechnicalSkill worker; // 操作员的技术对象
        private ITechnicalSkill device; // 设备（工作站）的技能要求
        public MatchSkillService(ITechnicalSkill wo, ITechnicalSkill de) {
            worker = wo;
            device = de;
        }
        public bool verifySkill() {
            return device.matchSkill(worker);
        }

    }
}
