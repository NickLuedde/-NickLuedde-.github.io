﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GAG_101.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GotAGuy_DB1Entities : DbContext
    {
        public GotAGuy_DB1Entities()
            : base("name=GotAGuy_DB1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<JobTypes1> JobTypes1 { get; set; }
        public virtual DbSet<UserReviews1> UserReviews1 { get; set; }
        public virtual DbSet<LocalBusinessUsers1> LocalBusinessUsers1 { get; set; }
        public virtual DbSet<LocalExperts1> LocalExperts1 { get; set; }
    }
}