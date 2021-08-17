using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NistagramUtils.Offline.Post.Model;

namespace NistagramUtils.Offline.Post
{
    public interface IPostServices
    {
        HashSet<OfflinePost> GetAllOfflinePosts();
        HashSet<User> GetAllNewUsers();
    }
}
