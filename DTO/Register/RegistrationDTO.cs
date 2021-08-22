using System;

namespace NistagramUtils.DTO.Register
{
    public class RegistrationDto
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string sex { get; set; }
        public DateTime? dateOfBirth { get; set; }
        public DateTime dateOfRegistration { get; set; }
    }
}
