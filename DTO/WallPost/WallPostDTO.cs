using NistagramSQLConnection.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NistagramUtils.DTO.WallPost
{
    public class WallPostDto
    {

        public long id { get; set; }

        public UserDto user { get; set; }

        public DateTime timePublis { get; set; }

        public string imagePost { get; set; }

        public string postDescription { get; set; }

        public int like { get; set; }

        public int dislike { get; set; }

        public WallPostDto(NistagramSQLConnection.Model.WallPost wp, NistagramSQLConnection.Model.User enumerable, ICollection<PostReaction> postReactions)
        {
            id = wp.id;
            user = new UserDto(enumerable);
            timePublis = wp.timePublis;
            imagePost = wp.imagePost;
            postDescription = wp.postDescription;
            IsLike(postReactions);
        }

        public WallPostDto(NistagramSQLConnection.Model.WallPost wp)
        {
            id = wp.id;
            if (wp.userPosts.Count > 0)
            {
                user = new UserDto(wp.userPosts.Select(x => x.user).FirstOrDefault());
            }
            timePublis = wp.timePublis;
            imagePost = wp.imagePost;
            postDescription = wp.postDescription;
            IsLike(wp.postReactions);
        }

        private void IsLike(ICollection<PostReaction> postReactions)
        {
            int countLike = 0;
            int countDislike = 0;

            foreach (var reaction in postReactions)
            {
                if (reaction.reaction.type == true) countLike += 1;
                if (reaction.reaction.type == false) countDislike += 1;
            }
            like = countLike;
            dislike = countDislike;
        }
    }
}