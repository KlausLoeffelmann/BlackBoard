using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackboardWebApi.Model
{
    public class UserInfo
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string PreferredUserName { get; set; }
        public string FrontPage { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
