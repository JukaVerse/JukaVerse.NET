using JukaVerse.NET.server;
using Microsoft.Extensions.Hosting;

namespace JukaVerse
{
    public class TEST
    {
        public static void Main(string[] arguments)
        {
            ServerBuilder serverBuilder = new ServerBuilder();
            NET.schema.Server server = new NET.schema.Server();
            server.SERVER_HOST_IP = "127.0.0.1";
            server.ONLINE_USERS = new List<NET.schema.User>();
            server.SERVER_PORT = 2999;

            ServerBuilder.createServer(server, "First JukaVerse Server", arguments, isPublic: false, requirePassword: true, serverPassword: "123").Build().Run();

        }
    }
}