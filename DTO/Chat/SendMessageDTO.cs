using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NistagramUtils.DTO.Chat
{
    public class SendMessageDto
    {
        public string text { get; set; }
        public long userId { get; set; }
        public long friendId { get; set; }
    }
}
