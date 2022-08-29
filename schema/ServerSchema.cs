using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JukaVerse.NET.schema
{
    public class Server
    {
        public string SERVER_HOST_IP { get; set; }
        public int SERVER_PORT { get; set; }
        public List<User> ONLINE_USERS { get; set; }

    }
}
