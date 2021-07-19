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
        //public bool loginWorker(AppUser user) {
        //    // TODO 这儿登录用户肯定不对，ABP已经实现了登录的
        //}
    }
}
