using AutoMapper;
using SmartAbp.Books;

namespace SmartAbp.Web
{
    public class SmartAbpWebAutoMapperProfile : Profile
    {
        public SmartAbpWebAutoMapperProfile()
        {
            //Define your AutoMapper configuration here for the Web project.
            CreateMap<BookDto, CreateUpdateBookDto>();
        }
    }
}
