using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NistagramUtils.DTO
{
    public class LoginResponseDTO
    {
        public string status;
        public string jwt;
        public UserDTO userDTO;
    }
}
