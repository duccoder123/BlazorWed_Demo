using AutoMapper;
using BlazorDemo_DataAccess;
using BlazorDemo_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDemo_Business.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile() 
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
        }
    }
}
