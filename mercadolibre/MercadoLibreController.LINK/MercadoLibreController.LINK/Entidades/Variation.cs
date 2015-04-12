using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoLibreController.LINK.Entidades
{
    public class Variation
    {
        public List<AttributeCombination> attribute_combinations { get; set; }
        public int price { get; set; }
        public List<string> picture_ids { get; set; }
        public int available_quantity { get; set;    }

        public Variation()
        {
            attribute_combinations = new List<AttributeCombination>();
            picture_ids = new List<string>();
        }
    }
}
