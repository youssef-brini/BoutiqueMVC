﻿// <auto-generated />
using System;
using Boutique.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Boutique.Migrations
{
    [DbContext(typeof(BoutiqueDbContext))]
    [Migration("20211124071825_migration1")]
    partial class migration1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Boutique.Models.Commande", b =>
                {
                    b.Property<int>("CommandeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EmployePersonneId")
                        .HasColumnType("int");

                    b.Property<int?>("FournisseurId")
                        .HasColumnType("int");

                    b.Property<string>("dateCommande")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dateLivraison")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CommandeId");

                    b.HasIndex("EmployePersonneId");

                    b.HasIndex("FournisseurId");

                    b.ToTable("Commandes");
                });

            modelBuilder.Entity("Boutique.Models.CommandeProduct", b =>
                {
                    b.Property<int>("CommandeProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CommandeId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantite")
                        .HasColumnType("int");

                    b.HasKey("CommandeProductId");

                    b.HasIndex("CommandeId");

                    b.HasIndex("ProductId");

                    b.ToTable("CommandeProduct");
                });

            modelBuilder.Entity("Boutique.Models.Fournisseur", b =>
                {
                    b.Property<int>("FournisseurId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Addresse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telephone")
                        .HasColumnType("int");

                    b.HasKey("FournisseurId");

                    b.ToTable("Fournisseurs");
                });

            modelBuilder.Entity("Boutique.Models.Livraison", b =>
                {
                    b.Property<int>("LivraisonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EmployePersonneId")
                        .HasColumnType("int");

                    b.Property<int?>("VenteId")
                        .HasColumnType("int");

                    b.Property<string>("adresseLivraison")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LivraisonId");

                    b.HasIndex("EmployePersonneId");

                    b.HasIndex("VenteId");

                    b.ToTable("Livraisons");
                });

            modelBuilder.Entity("Boutique.Models.Personne", b =>
                {
                    b.Property<int>("PersonneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Addresse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telephone")
                        .HasColumnType("int");

                    b.HasKey("PersonneId");

                    b.ToTable("Personnes");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Personne");
                });

            modelBuilder.Entity("Boutique.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("ProductPrice")
                        .HasColumnType("real");

                    b.Property<string>("ProductType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuantiteDispo")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Boutique.Models.ProductVente", b =>
                {
                    b.Property<int>("ProductVenteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("QuantiteDesi")
                        .HasColumnType("int");

                    b.Property<int>("VenteId")
                        .HasColumnType("int");

                    b.HasKey("ProductVenteId");

                    b.HasIndex("ProductId");

                    b.HasIndex("VenteId");

                    b.ToTable("ProductVente");
                });

            modelBuilder.Entity("Boutique.Models.Vente", b =>
                {
                    b.Property<int>("VenteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClientPersonneId")
                        .HasColumnType("int");

                    b.Property<int>("Mode_payment")
                        .HasColumnType("int");

                    b.Property<float>("Montant")
                        .HasColumnType("real");

                    b.HasKey("VenteId");

                    b.HasIndex("ClientPersonneId");

                    b.ToTable("Ventes");
                });

            modelBuilder.Entity("Boutique.Models.Client", b =>
                {
                    b.HasBaseType("Boutique.Models.Personne");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Client");
                });

            modelBuilder.Entity("Boutique.Models.Employe", b =>
                {
                    b.HasBaseType("Boutique.Models.Personne");

                    b.Property<int>("EmployeId")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Employe");
                });

            modelBuilder.Entity("Boutique.Models.Commande", b =>
                {
                    b.HasOne("Boutique.Models.Employe", "Employe")
                        .WithMany()
                        .HasForeignKey("EmployePersonneId");

                    b.HasOne("Boutique.Models.Fournisseur", "Fournisseur")
                        .WithMany()
                        .HasForeignKey("FournisseurId");

                    b.Navigation("Employe");

                    b.Navigation("Fournisseur");
                });

            modelBuilder.Entity("Boutique.Models.CommandeProduct", b =>
                {
                    b.HasOne("Boutique.Models.Commande", "Commande")
                        .WithMany("CommandeProducts")
                        .HasForeignKey("CommandeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Boutique.Models.Product", "Product")
                        .WithMany("CommandeProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Commande");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Boutique.Models.Livraison", b =>
                {
                    b.HasOne("Boutique.Models.Employe", "Employe")
                        .WithMany()
                        .HasForeignKey("EmployePersonneId");

                    b.HasOne("Boutique.Models.Vente", "Vente")
                        .WithMany()
                        .HasForeignKey("VenteId");

                    b.Navigation("Employe");

                    b.Navigation("Vente");
                });

            modelBuilder.Entity("Boutique.Models.ProductVente", b =>
                {
                    b.HasOne("Boutique.Models.Product", "Product")
                        .WithMany("ProductVentes")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Boutique.Models.Vente", "Vente")
                        .WithMany("ProductVentes")
                        .HasForeignKey("VenteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Vente");
                });

            modelBuilder.Entity("Boutique.Models.Vente", b =>
                {
                    b.HasOne("Boutique.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientPersonneId");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Boutique.Models.Commande", b =>
                {
                    b.Navigation("CommandeProducts");
                });

            modelBuilder.Entity("Boutique.Models.Product", b =>
                {
                    b.Navigation("CommandeProducts");

                    b.Navigation("ProductVentes");
                });

            modelBuilder.Entity("Boutique.Models.Vente", b =>
                {
                    b.Navigation("ProductVentes");
                });
#pragma warning restore 612, 618
        }
    }
}