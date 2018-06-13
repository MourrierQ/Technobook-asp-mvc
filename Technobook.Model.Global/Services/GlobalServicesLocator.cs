using Patterns.Locator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technobook.Model.Global.Services
{
    public class GlobalServicesLocator:LocatorBase
    {
        private static GlobalServicesLocator _Instance;

        public static GlobalServicesLocator Instance
        {
            get { return _Instance ?? (_Instance = new GlobalServicesLocator()); }
        }

        public GlobalServicesLocator()
        {
            Container.Register<UserRepository>();
            Container.Register<RelationRepository>();
            Container.Register<PostRepository>();
        }

        public UserRepository Users
        {
            get
            {
                return Container.GetInstance<UserRepository>();
            }
        }

        public RelationRepository Relations
        {
            get
            {
                return Container.GetInstance<RelationRepository>();
            }
        }

        public PostRepository Posts
        {
            get
            {
                return Container.GetInstance<PostRepository>();
            }
        }
    }
}
