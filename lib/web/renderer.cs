using System.Net;

namespace JukaVerse.NET.ASPX
{
    public class renderer
    {
        public static string RenderIndex()
        {
            WebClient client = new WebClient();
            return client.DownloadString("https://raw.githubusercontent.com/JukaVerse/JukaVerse.NET/main/host/index.html");
        }
    }
}
