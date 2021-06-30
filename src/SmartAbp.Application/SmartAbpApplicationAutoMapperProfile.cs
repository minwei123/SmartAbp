using AutoMapper;
using SmartAbp.Books;
using SmartAbp.Stations;

namespace SmartAbp
{
    public class SmartAbpApplicationAutoMapperProfile : Profile
    {
        public SmartAbpApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            //这个是为把数据从后台传前台展示层
            CreateMap<Book, BookDto>();
            //这个是为了把后台展示层传递到前台
            CreateMap<CreateUpdateBookDto, Book>();
            //这个是为把数据从后台传前台展示层
            CreateMap<Station, StationDto>();
            //这个是为了把后台展示层传递到前台
            CreateMap<CreateUpdateStationDto, Station>();

        }
    }
}
