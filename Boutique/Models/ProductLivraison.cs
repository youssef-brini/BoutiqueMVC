using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boutique.Models
{
    public class ProductLivraison
    {
        public int ProductLivraisonId { get; set; }
        public int ProductId { get; set; }
        public int LivraisonId { get; set; }
        public Livraison Livraison { get; set; }
        public Product Product { get; set; }
    }
}
