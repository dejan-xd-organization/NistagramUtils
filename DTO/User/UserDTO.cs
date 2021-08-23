
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

        public UserDto() { }

        public UserDto(NistagramSQLConnection.Model.User user)
        {
            id = user.id;
            firstName = user.firstName;
            lastName = user.lastName;
            username = user.username;
            email = user.email;
            img = user.profileImg;
        }
    }
}
