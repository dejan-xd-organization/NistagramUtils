using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NistagramUtils.Offline.Post.Model
{
    public class User
    {
        private long id;
        private string firstName;
        private string lastName;
        private string username;
        private string img;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Img
        {
            get { return img; }
            set { img = value; }
        }
    }
}
