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

        public Stock Stock { get; set; }
        public IList<ProductLivraison> ProductsLivraisons { get; set; }
        public IList<ProductFournisseur> ProductsFournisseurs { get; set; }
        public Commande Commande { get; set; }
        public Vente Vente { get; set; }
        public Client Client { get; set; }


    }
}
