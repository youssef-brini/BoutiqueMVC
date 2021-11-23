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
            modelBuilder
                .Entity<Client>()
                .HasMany<Product>(c => c.Products)
                .WithOne(p => p.Client)
                //.OnDelete(DeleteBehavior.Cascade);
                .OnDelete(DeleteBehavior.SetNull);
            modelBuilder
                .Entity<Client>()
                .HasMany<Vente>(c => c.Ventes)
                .WithOne(v => v.Client)
                //.OnDelete(DeleteBehavior.Cascade);
                .OnDelete(DeleteBehavior.SetNull);
            modelBuilder
                .Entity<Vente>()
                .HasMany<Product>(v => v.Products)
                .WithOne(p => p.Vente)
                //.OnDelete(DeleteBehavior.Cascade);
                .OnDelete(DeleteBehavior.SetNull);
            modelBuilder
               .Entity<Employe>()
               .HasMany<Livraison>(e => e.Livraisons)
               .WithOne(l => l.Employe)
               //.OnDelete(DeleteBehavior.Cascade);
               .OnDelete(DeleteBehavior.SetNull);
            modelBuilder
               .Entity<Employe>()
               .HasMany<Commande>(e => e.Commandes)
               .WithOne(c => c.Employe)
               //.OnDelete(DeleteBehavior.Cascade);
               .OnDelete(DeleteBehavior.SetNull);
            modelBuilder
                .Entity<Commande>()
                .HasMany<Product>(c => c.Products)
                .WithOne(p => p.Commande)
                //.OnDelete(DeleteBehavior.Cascade);
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder
               .Entity<Product>()
               .HasMany<ProductFournisseur>(p => p.ProductsFournisseurs)
               .WithOne(pf => pf.Product)
               .OnDelete(DeleteBehavior.Cascade);
               //.OnDelete(DeleteBehavior.SetNull);
            modelBuilder
               .Entity<Fournisseur>()
               .HasMany<ProductFournisseur>(f => f.ProductsFournisseurs)
               .WithOne(pf => pf.Fournisseur)
               .OnDelete(DeleteBehavior.Cascade);
            //.OnDelete(DeleteBehavior.SetNull);

            modelBuilder
               .Entity<Product>()
               .HasMany<ProductLivraison>(p => p.ProductsLivraisons)
               .WithOne(pl => pl.Product)
               .OnDelete(DeleteBehavior.Cascade);
            //.OnDelete(DeleteBehavior.SetNull);
            modelBuilder
               .Entity<Livraison>()
               .HasMany<ProductLivraison>(l => l.ProductsLivraisons)
               .WithOne(pf => pf.Livraison)
               .OnDelete(DeleteBehavior.Cascade);
            //.OnDelete(DeleteBehavior.SetNull);

            modelBuilder
               .Entity<Fournisseur>()
               .HasMany<FournisseurCommande>(f => f.FournisseursCommandes)
               .WithOne(fc => fc.Fournisseur)
               .OnDelete(DeleteBehavior.Cascade);
            //.OnDelete(DeleteBehavior.SetNull);
            modelBuilder
               .Entity<Commande>()
               .HasMany<FournisseurCommande>(c => c.FournisseursCommandes)
               .WithOne(fc => fc.Commande)
               .OnDelete(DeleteBehavior.Cascade);
            //.OnDelete(DeleteBehavior.SetNull);


            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Personne> Personnes { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Fournisseur> Fournisseurs { get; set; }
        public DbSet<Employe> Employes { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<Livraison> Livraisons { get; set; }
        public DbSet<Vente> Ventes { get; set; }
    }
}
