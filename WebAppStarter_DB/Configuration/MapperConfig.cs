using AutoMapper;
using WebAppStarter_DB.DTO;
using WebAppStarter_DB.Models;

namespace WebAppStarter_DB.Configuration
{
    public class MapperConfig : Profile
    {

        public MapperConfig() 
        {
            CreateMap<StudentInsertDTO, Student>().ReverseMap();
            CreateMap<StudentUpdateDTO, Student >().ReverseMap();
            CreateMap<StudentReadOnlyDTO, Student>().ReverseMap();
        }
    }
}
