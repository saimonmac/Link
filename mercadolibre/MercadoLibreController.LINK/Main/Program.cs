using MercadoLibre.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Meli m = new Meli(4234362235449505, "WbcImMtF6cRRtQQd7wRaqQy1MBmjSW9U");
            string redirectUrl = m.GetAuthUrl("http://www.google.com");
            m.Authorize("the received code", "http://somecallbackurl");
        }
    }
}
