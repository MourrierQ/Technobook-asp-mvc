using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technobook.Model.Global.Models
{
    public class Post
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string Content { get; set; }
        public DateTime PostDate { get; set; }
    }
}
