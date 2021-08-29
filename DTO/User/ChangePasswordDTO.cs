namespace NistagramUtils.DTO.User
{
    public class ChangePasswordDto
    {
        public long id { get; set; }
        public string oldPassword { get; set; }
        public string newPassword { get; set; }
    }
}
