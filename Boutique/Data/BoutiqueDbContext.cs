using Boutique.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boutique.Data
{
    public class BoutiqueDbContext :DbContext
    {
        public BoutiqueDbContext(DbContextOptions<BoutiqueDbContext> options) :base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            //.OnDelete(DeleteBehavior.Cascade);
            //.OnDelete(DeleteBehavior.SetNull);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Product> Products { get; set; }
        
        public DbSet<Personne> Personnes { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Fournisseur> Fournisseurs { get; set; }
        public DbSet<Employe> Employes { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<Livraison> Livraisons { get; set; }
        public DbSet<Vente> Ventes { get; set; }
    }
}
