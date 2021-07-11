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
}
