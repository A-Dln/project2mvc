﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PROJECT2MVC.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CRMEntities : DbContext
    {
        public CRMEntities()
            : base("name=CRMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Bedrijf> Bedrijven { get; set; }
        public DbSet<Categorie> Categorieën { get; set; }
        public DbSet<Opportuniteit> Opportuniteiten { get; set; }
        public DbSet<Persoon> Personen { get; set; }
        public DbSet<Product> Producten { get; set; }
        public DbSet<VerkoopRegel> VerkoopRegels { get; set; }
        public DbSet<Verkoop> Verkopen { get; set; }
    }
}
