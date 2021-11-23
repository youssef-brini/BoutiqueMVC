using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boutique.Models
{
   public class Fournisseur:Personne
    {
        public int FournisseurId { get; set; }
        public IList<FournisseurCommande> FournisseursCommandes { get; set; }
        public IList<ProductFournisseur> ProductsFournisseurs { get; set; }


    }
}
