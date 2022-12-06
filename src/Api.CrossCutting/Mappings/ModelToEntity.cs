using AutoMapper;
using Domain.Entities;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.Mappings
{
    public class ModelToEntity : Profile
    {
        public ModelToEntity()
        {
            CreateMap<UserEntity, UserModel>().ReverseMap();
        }
    }
}
