using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = Technobook.Model.Client.Models;
using G = Technobook.Model.Global.Models;

namespace Technobook.Model.Client.Mappers
{
    public static class RelationMappers
    {
        public static C.Relation ToClient(this G.Relation r)
        {
            return new C.Relation(r.UserID, r.FriendID, r.Accepted);
        }

        public static G.Relation ToGlobal(this C.Relation r)
        {
            return new G.Relation
            {
                UserID = r.UserID,
                FriendID = r.FriendID,
                Accepted = r.Answer
            };
        }
    }
}
