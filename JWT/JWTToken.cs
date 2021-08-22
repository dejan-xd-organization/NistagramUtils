using Microsoft.IdentityModel.Tokens;
using NistagramSQLConnection.Model;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace NistagramUtils.JWT
{
    public class JwtToken
    {
        private const string SecretKey = "uUtEMfZVfgMXdRWky0HHSCjS2C2xMogRwy/3DSjiDj99Vy8ECD0Jv9KOibLRz70shjFSL0JNlV4Hbe4VGMJfMO0SFMg9dpFoFUL5ZJfb4W9BP6JpzYtEJZREPF+GTRjLtFT5nCY98dOzZFR3XnLijtLg9+I7ceg1tZ1CDXHF5tE=";

        public JwtToken() { }

        public static string GenerateJSONWebToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(SecretKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.id.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
