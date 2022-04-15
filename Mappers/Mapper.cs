using AutoMapper;
using BootcampAPIProje.DTOs;
using BootcampAPIProje.Models;

namespace BootcampAPIProje.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Kitap, KitapDto>().ReverseMap();
        }
    }
}
