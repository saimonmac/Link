using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoLibreController.LINK.Entidades
{
   public class results
    {
    
       public List<result> result { get; set; }

       public results() {
          
           result = new List<result>();
       }
    }
}
