﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoLibreController.LINK.Entidades
{
   public  class Order_item
    {
       public DetailedItem   item { get; set; }
       public string quantity { get; set; }

       public Order_item() {
           
       }
    }
}
