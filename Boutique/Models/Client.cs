using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boutique.Models
{
    public class Client:Personne
    {
        public int ClientId { get; set; }

        public IList<Product> Products { get; set; }

        public IList<Vente> Ventes { get; set; }
    }
}
