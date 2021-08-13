using System;
using System.Collections.Generic;

namespace NistagramUtils.Offline.Post.Model
{
    public class OfflinePost
    {
        private long id { get; set; }
        private User1 user { get; set; }
        private DateTime timePublished { get; set; }
        private string postImage { get; set; }
        private int likes { get; set; }
        private int dislikes { get; set; }
        private string postDescription { get; set; }
        private List<OfflinePostComments> offlinePostComments { get; set; }


    }
}
