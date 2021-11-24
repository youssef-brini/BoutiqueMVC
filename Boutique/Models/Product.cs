using System;
using System.Collections.Generic;

namespace Boutique.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }

        public string ProductType { get; set; }
        public float ProductPrice { get; set; }
        public string ProductImg { get; set; }
        public int QuantiteDispo { get; set; }
        public IList<ProductVente> ProductVentes { get; set; }
        public IList<CommandeProduct> CommandeProducts { get; set; }




    }
}
