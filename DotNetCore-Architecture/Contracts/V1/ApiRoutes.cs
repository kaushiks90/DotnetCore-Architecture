using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore_Architecture.Contracts
{
    public static class ApiRoutes
    {
        public const string Root = "v1";
        public const string Version = "v1";
        public  const string Base = Root + "/" + Version;

        public static class Posts
        {
            public const string GetAll = Base + "/posts";
        }
    }
}
