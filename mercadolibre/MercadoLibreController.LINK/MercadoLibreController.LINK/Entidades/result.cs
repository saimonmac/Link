using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoLibreController.LINK.Entidades
{
   public class result
    {
       public string id { get; set; }
       public List<order_items> order_items { get; set; }
       public buyer buyer { get; set; }
       public result() {

           order_items = new List<order_items>();
       }
    }
}
