using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
namespace SmartAbp.Stations
{
    public interface IStationAppService:
            ICrudAppService< //Defines CRUD methods
            StationDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateStationDto> //Used to create/update a book
    {
    }
}
