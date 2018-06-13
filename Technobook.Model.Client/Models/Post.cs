using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technobook.Model.Client.Models
{
    public class Post
    {
        private int _ID;
        private int _UserID;
        private string _Content;
        private DateTime _PostDate;

        public int ID
        {
            get { return _ID; }
            private set { _ID = value; }
        }


        public int UserID
        {
            get { return _UserID; }
            private set { _UserID = value; }
        }


        public string Content
        {
            get { return _Content; }
            private set { _Content = value; }
        }


        public DateTime PostDate
        {
            get { return _PostDate; }
            private set { _PostDate = value; }
        }

        public Post(int ID, int UserID, string Content, DateTime PostDate)
        {
            this.ID = ID;
            this.UserID = UserID;
            this.Content = Content;
            this.PostDate = PostDate;
        }

    }
}
