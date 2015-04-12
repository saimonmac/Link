using MercadoLibre.SDK;
using MercadoLibreController.LINK.Entidades;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
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
        private long app_id;
        private string secret;
        private List<Category> categories;


        public void GetCategoriesMercadoLibre(){
            var p = new Parameter ();
            p.Name = "access_token";
            p.Value = token;
            var ps = new List<Parameter> ();
            ps.Add (p);
            IRestResponse r = meli.Get("/sites/MLU/categories", ps);
            categories = JsonConvert.DeserializeObject<List<Category>>(r.Content);
        }

        private MercadoLibreController()
        {

        }

        public void SetCredentials(long id, string secret)
        {
            this.app_id = id;
            this.secret = secret;
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
            GetCategoriesMercadoLibre();
            Publish("");
            return true;
        
        }

        public bool Publish(string json)
        {
            var p = new Parameter();
            p.Name = "access_token";
            p.Value = token;
            //aca va un conversor del json a articulomeli
            ArticleMeli a = new ArticleMeli() { title = "Lentes 1", buying_mode = "buy_it_now", condition = "new", category_id = "MLU158362", currency_id = "UYU", description = "Nada", listing_type_id = "bronze", available_quantity = 10, price = 100, video_id = "", warranty = "No warranty", pictures = new List<Picture>() { new Picture() { source = "http://en.wikipedia.org/wiki/File:Teashades.gif" } } }; 
            var ps = new List<Parameter>();
            ps.Add(p);
            string articulo = JsonConvert.SerializeObject(a);
            IRestResponse r = meli.Post("/items",ps,articulo);
            return false;
        }
    }
}
