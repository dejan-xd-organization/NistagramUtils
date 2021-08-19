using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using NistagramSQLConnection.Model;
using NistagramUtils.DTO;
using NistagramUtils.DTO.Register;

namespace NistagramUtils.Mapper
{
    public class SimpleMapper : Profile
    {
        public SimpleMapper()
        {
            CreateMap<UserDTO, User>();
            CreateMap<User, UserDTO>();

            CreateMap<RegistrationDTO, User>();
            CreateMap<User, RegistrationDTO>();
        }
    }
}