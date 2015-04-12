﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoLibreController.LINK.Entidades
{
    public class ArticleERP
    {
        public string title { get; set; }
        public int price { get; set; }
        public int available_quantity { get; set; }
        public string description { get; set; }
        public string warranty { get; set; }

        public ArticleERP()
        {
        }
    }
}
