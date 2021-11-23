using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boutique.Models
{
    public class FournisseurCommande
    {
        public int FournisseurCommandeId { get; set; }
        public int FournisseurId { get; set; }
        public int CommandeId { get; set; }
        public Commande Commande { get; set; }
        public Fournisseur Fournisseur { get; set; }
    }
}
