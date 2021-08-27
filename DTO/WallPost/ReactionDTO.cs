using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NistagramUtils.DTO.WallPost
{
    public class ReactionDto
    {
        public long id { get; set; }
        public bool type { get; set; }
        public long userId { get; set; }

    }
}
