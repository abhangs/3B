﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _3B
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class bookstoreEntities1 : DbContext
    {
        public bookstoreEntities1()
            : base("name=bookstoreEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<admin> admins { get; set; }
        public DbSet<adminphone> adminphones { get; set; }
        public DbSet<author> authors { get; set; }
        public DbSet<book> books { get; set; }
        public DbSet<category> categories { get; set; }
        public DbSet<creditcardtype> creditcardtypes { get; set; }
        public DbSet<customer> customers { get; set; }
        public DbSet<order> orders { get; set; }
        public DbSet<review> reviews { get; set; }
        public DbSet<sale> sales { get; set; }
        public DbSet<salesline> saleslines { get; set; }
        public DbSet<state> states { get; set; }
    }
}