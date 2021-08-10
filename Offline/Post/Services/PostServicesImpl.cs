using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NistagramUtils.Offline.Post.Model;

namespace NistagramUtils.Offline.Post.Services
{
    public class PostServicesImpl : IPostServices
    {
        public HashSet<OfflinePost> GetAllOfflinePosts()
        {
            return new HashSet<OfflinePost>(0);
        }

        public HashSet<User> GetAllNewUsers()
        {
            return new HashSet<User>(0);
        }
    }
}
