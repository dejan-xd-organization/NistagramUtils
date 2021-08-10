using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NistagramUtils.Offline.Post.Model
{
    public class OfflinePost
    {
        private long id;
        private User user;
        private DateTime timePublished;
        private string postImage;
        private int likes;
        private int dislikes;
        private string postDescription;
        private List<OfflinePostComments> offlinePostComments;


    }
}
