using AutoMapper;
using Domain.DTOs.User;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.Mappings
{
    public class EntityToDTO : Profile
    {
        public EntityToDTO()
        {
            CreateMap<UserDTOCreate, UserEntity>().ReverseMap();

            CreateMap<UserDTOCreateResult, UserEntity>().ReverseMap();

            CreateMap<UserDTOUpdateResult, UserEntity>().ReverseMap();
        }
    }
}
