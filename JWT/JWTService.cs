using NistagramSQLConnection.Model;
using System.Collections.Generic;

namespace NistagramUtils.JWT
{
    public static class JwtService
    {
        private static Dictionary<string, User> activeUsers = new Dictionary<string, User>();

        public static bool AddActiveUser(string jwt, User user)
        {
            User u = null;
            if (!activeUsers.TryGetValue(jwt, out u))
            {
                if (!activeUsers.TryAdd(jwt, user))
                {
                    return true;
                }
                return false;
            }
            else
            {
                if (!activeUsers.Remove(jwt))
                {
                    return false;
                }
                return activeUsers.TryAdd(jwt, user);
            }
        }
    }
}
