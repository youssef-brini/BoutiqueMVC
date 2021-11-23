using System;
using System.Collections.Generic;

namespace Boutique.Models
{
    public class Stock
    {

        public int StockId{ get; set; }
        public int Quantite { get; set; }
        public IList<Product> Products { get; set; }
        public Employe Employe { get; set; }
    }
}
