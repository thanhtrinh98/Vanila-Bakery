﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VanilaBakery.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VanilaEntities : DbContext
    {
        public VanilaEntities()
            : base("name=VanilaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<ADMIN> ADMINs { get; set; }
        public virtual DbSet<BANH> BANHs { get; set; }
        public virtual DbSet<BLOG> BLOGs { get; set; }
        public virtual DbSet<CHITIETDONTHANG> CHITIETDONTHANGs { get; set; }
        public virtual DbSet<DauBep> DauBeps { get; set; }
        public virtual DbSet<DONDATHANG> DONDATHANGs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<LIENHE> LIENHEs { get; set; }
        public virtual DbSet<LOAI> LOAIs { get; set; }
        public virtual DbSet<SUBCRIBE> SUBCRIBEs { get; set; }
        public virtual DbSet<TAG> TAGs { get; set; }
        public virtual DbSet<ThuVienAnh> ThuVienAnhs { get; set; }
    }
}
