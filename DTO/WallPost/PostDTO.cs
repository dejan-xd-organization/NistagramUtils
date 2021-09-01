using System;

namespace NistagramUtils.DTO.WallPost
{
    public class PostDto
    {
        public long userId { get; set; }
        public string description { get; set; }
        public bool isPublic { get; set; }

    }

    public class PostResponseDto
    {

        public long id { get; set; }

        public DateTime timePublis { get; set; }

        public string imagePost { get; set; }

        public string postDescription { get; set; }

        public bool isPublic { get; set; }  // is wall post public or not?

        public PostResponseDto(NistagramSQLConnection.Model.WallPost wallPost)
        {
            id = wallPost.id;
            timePublis = wallPost.timePublis;
            imagePost = wallPost.imagePost;
            postDescription = wallPost.postDescription;
            isPublic = wallPost.isPublic;
        }
    }
}