using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technobook.Model.Client.Mappers;
using Technobook.Model.Client.Models;
using Technobook.Model.Global.Services;

namespace Technobook.Model.Client.Services
{
    public class PostServices
    {
        public IEnumerable<Post> GetFriendsPosts(int id)
        {
            return GlobalServicesLocator.Instance.Posts.GetFriendsPosts(id).Select(p => p.ToClient());
        }

        public IEnumerable<Post> GetPostsFromUser(int id)
        {
            return GlobalServicesLocator.Instance.Posts.GetPostsFromUser(id).Select(p => p.ToClient());
        }

        public Post InsertPost(Post entity)
        {
            return GlobalServicesLocator.Instance.Posts.InsertPost(entity.ToGlobal()).ToClient();
        }
    }
}
