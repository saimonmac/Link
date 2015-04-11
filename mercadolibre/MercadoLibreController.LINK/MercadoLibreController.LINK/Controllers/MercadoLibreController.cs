using MercadoLibre.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoLibreController.LINK.Controllers
{
    public class MercadoLibreController
    {
        private static MercadoLibreController mercadolibre_controller = null;
        public string Code { get; set; }
        private Meli meli;
        private string token; 

        private MercadoLibreController()
        {

        }

        public static MercadoLibreController GetController()
        {
            if (mercadolibre_controller == null)
            {
                mercadolibre_controller = new MercadoLibreController();
            }
            return mercadolibre_controller;
        }

        public string Connect()
        {
            meli = new Meli(6811854697761224, "tjNL5zqG1GYbrSKYL5kOXbc6XOZXuSIE");
            string redirectUrl = meli.GetAuthUrl("http://localhost/PruebaOauth/Redirect.aspx");
            return redirectUrl;
        }

        public bool Authorize()
        {
            meli.Authorize(Code, "http://localhost/PruebaOauth/Redirect.aspx");
            //guardar el token y el code en la base de datos

            token = meli.AccessToken;
            return true;
        
        }
    }
}
