using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boutique.Models
{
    public class ProductFournisseur
    {
        public int ProductFournisseurId { get; set; }
        public int ProductId { get; set; }
        public int FournisseurId { get; set; }
        public  Product Product { get; set; }
        public  Fournisseur Fournisseur { get; set; }
    }
}
