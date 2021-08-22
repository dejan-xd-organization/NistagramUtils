using AutoMapper;
using NistagramSQLConnection.Model;
using NistagramUtils.DTO;
using NistagramUtils.DTO.Register;
using NistagramUtils.DTO.WallPost;

namespace NistagramUtils.Mapper
{
    public class SimpleMapper : Profile
    {
        public SimpleMapper()
        {
            CreateMap<UserDto, User>();
            CreateMap<User, UserDto>();

            CreateMap<RegistrationDto, User>();
            CreateMap<User, RegistrationDto>();

            CreateMap<WallPostDto, WallPost>();
            CreateMap<WallPost, WallPostDto>();
        }
    }
}