using Spectre.Console;

namespace JukaVerse.NET.server
{
    public class ServerBuilder
    {
        public async void build(JukaVerse.NET.schema.Server serverSchema,
            string ServerName,
            bool isPublic = true,
            bool requirePassword = false,
            string serverPassword = "")
        {
            AnsiConsole.Status().Start("Starting JukaVerse Server", ctx =>
            {
                string isPublinConf = isPublic == true ? "[yellow]Server is set to public privacy.[/]" : "[yellow]Server is set to private privacy.[/]";
                Thread.Sleep(1000);
                AnsiConsole.MarkupLine(isPublinConf);                
            });
        }
    }
}
