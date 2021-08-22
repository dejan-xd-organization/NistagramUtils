using System;

namespace NistagramUtils.DTO.WallPost
{
    public class WallPostDto
    {
        public long id { get; set; }

        public DateTime timePublis { get; set; }

        public string imagePost { get; set; }

        public string postDescription { get; set; }
    }
}
