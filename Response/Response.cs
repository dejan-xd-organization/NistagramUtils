using NistagramUtils.DTO.User;

namespace NistagramUtils.Response
{
    public class Response
    {
        public string status { get; set; }
        public string message { get; set; }
        public UpdateUserDto updateUserDto { get; set; }
        public ChangePasswordDto changePasswordDto { get; set; }
    }
}
