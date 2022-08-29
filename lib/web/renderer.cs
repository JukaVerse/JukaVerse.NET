using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JukaVerse.NET.ASPX
{
    public class renderer
    {
        public static string RenderIndex()
        {
            return System.IO.File.ReadAllText("../../host/index.html");
        }
    }
}
