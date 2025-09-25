using AutoMapper;
using JadooTravel.Dtos.CategoryDtos;
using JadooTravel.Dtos.DestinationDtos;
using JadooTravel.Entites;

namespace JadooTravel.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();

            CreateMap<Destination, CreateDestinationDto>().ReverseMap();
            CreateMap<Destination, GetDestinationByIdDto>().ReverseMap();
            CreateMap<Destination, ResultDestinationDto>().ReverseMap();
            CreateMap<Destination, UpdateDestinationDto>().ReverseMap();
        }
    }
}
