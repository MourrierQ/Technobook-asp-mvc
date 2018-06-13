using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technobook.Model.Client.Models
{
    public class Relation
    {
        private int _UserID;
        private int _FriendID;
        private bool _Answer;

        public bool Answer
        {
            get { return _Answer; }
            set { _Answer = value; }
        }


        public int UserID
        {
            get { return _UserID; }
            private set { _UserID = value; }
        }


        public int FriendID
        {
            get { return _FriendID; }
            private set { _FriendID = value; }
        }

        public Relation(int UserID, int FriendID, bool Answer = false)
        {
            this.UserID = UserID;
            this.FriendID = FriendID;
            this.Answer = Answer;
        }
    }
}
