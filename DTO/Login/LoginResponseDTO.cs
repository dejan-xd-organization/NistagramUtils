namespace NistagramUtils.DTO
{
    public class LoginResponseDto
    {
        public string status { get; set; }
        public string jwt { get; set; }
        public UserDto userDTO { get; set; }
    }
}
