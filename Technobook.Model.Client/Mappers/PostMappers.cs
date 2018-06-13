using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = Technobook.Model.Client.Models;
using G = Technobook.Model.Global.Models;

namespace Technobook.Model.Client.Mappers
{
    public static class PostMappers
    {
        public static C.Post ToClient(this G.Post entity)
        {
            return new C.Post(entity.ID, entity.UserID, entity.Content, entity.PostDate);
        }

        public static G.Post ToGlobal(this C.Post entity)
        {
            return new G.Post()
            {
                ID = entity.ID,
                UserID = entity.UserID,
                Content = entity.Content,
                PostDate = entity.PostDate
            };
        }
    }
}
