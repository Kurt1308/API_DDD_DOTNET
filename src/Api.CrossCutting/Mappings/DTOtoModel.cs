using AutoMapper;
using Domain.DTOs.User;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.Mappings
{
    public class DTOtoModel : Profile
    {
        public DTOtoModel()
        {
            CreateMap<UserModel, UserDTO>().ReverseMap();
        }
    }
}
