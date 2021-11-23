using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boutique.Models
{
    public class Employe:Personne
    {
        public int EmployeId { get; set; }
        public string Type { get; set; }
        public int StockId { get; set; }
        public Stock Stock { get; set; }
        public IList<Commande> Commandes { get; set; }
        public IList<Livraison> Livraisons { get; set; }

    }
}
