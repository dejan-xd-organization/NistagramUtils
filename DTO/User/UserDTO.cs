using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NistagramSQLConnection.Model;

namespace NistagramUtils.DTO
{
    public class UserDTO : UserInformationDTO
    {
        public long id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string img { get; set; }

        public UserDTO() { }

        public UserDTO(User user)
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
