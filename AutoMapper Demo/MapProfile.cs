using AutoMapper;
using AutoMapper_Demo.Dtos;
using AutoMapper_Demo.Model;

namespace AutoMapper_Demo
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Book, BookDto>()
                .ForMember(dest => dest.Id, src=> src.MapFrom(src => src.BookId))
                .ReverseMap();
        }
    }
}
