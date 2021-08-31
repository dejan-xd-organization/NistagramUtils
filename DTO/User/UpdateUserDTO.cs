using System;
using NistagramSQLConnection.Model;

namespace NistagramUtils.DTO.User
{
    public class UpdateUserDto
    {
        public long id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string sex { get; set; }
        public bool isPublicProfile { get; set; }
        public string relationship { get; set; }
        public DateTime dateOfBirth { get; set; }
        public Address address { get; set; }
    }
}
