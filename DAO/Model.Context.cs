﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBEntities : DbContext
    {
        public DBEntities()
            : base("name=DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Breed> Breeds { get; set; }
        public virtual DbSet<Carer> Carers { get; set; }
        public virtual DbSet<Owner> Owners { get; set; }
        public virtual DbSet<PetDetail> PetDetails { get; set; }
        public virtual DbSet<Species> Species { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
