
using System;
using NistagramSQLConnection.Model;

namespace NistagramUtils.DTO
{
    public class UserDto : UserInformationDto
    {
        public long id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string img { get; set; }
        public Address address { get; set; }
        public string sex { get; set; }
        public string relationship { get; set; }
        public bool isPublicProfile { get; set; }  // is user profile public or not?
        public int? followers { get; set; }
        public int? followings { get; set; }
        public DateTime? dateOfBirth { get; set; }

        public UserDto() { }

        public UserDto(NistagramSQLConnection.Model.User user)
        {
            id = user.id;
            if (user.firstName != null) firstName = user.firstName;
            if (user.lastName != null) lastName = user.lastName;
            if (user.username != null) username = user.username;
            if (user.email != null) email = user.email;
            if (user.profileImg != null) img = user.profileImg;
            followers = user.userFollowers?.Count;
            followings = user.userFollowings?.Count;
            if (user.address != null) address = user.address;
            if (user.sex != null) sex = user.sex;
            if (user.relationship != null) relationship = user.relationship;
            isPublicProfile = user.isPublicProfile;
            if (user.dateOfBirth != null) dateOfBirth = user.dateOfBirth;

        }
    }
}
