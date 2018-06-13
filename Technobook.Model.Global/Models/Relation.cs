using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technobook.Model.Global.Models
{
    public class Relation
    {
        public int UserID { get; set; }
        public int FriendID { get; set; }
        public bool Accepted { get; set; }
    }
}
