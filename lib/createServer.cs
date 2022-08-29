using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Spectre.Console;

namespace JukaVerse.NET.server
{
    public class ServerBuilder
    {
        public static IHostBuilder createServer(JukaVerse.NET.schema.Server serverSchema,string ServerName,string[] args,bool isPublic = true,bool requirePassword = false,string serverPassword = "")
        {
            IHostBuilder host = Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<ASPX.ASMXWebServices>();
            });
            return host;
        }
    }
}
