using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Shuler_MasterPol.Models
{
    public partial class MasterPolDb : DbContext
    {
        public MasterPolDb()
            : base("name=MasterPolDb")
        {
        }

        public virtual DbSet<Material_type> Material_type { get; set; }
        public virtual DbSet<Partner> Partner { get; set; }
        public virtual DbSet<PartnerProduct> PartnerProduct { get; set; }
        public virtual DbSet<PartnerType> PartnerType { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductType> ProductType { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Partner>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<Partner>()
                .Property(e => e.TaxpayerNumber)
                .IsFixedLength();

            modelBuilder.Entity<Partner>()
                .HasMany(e => e.PartnerProduct)
                .WithRequired(e => e.Partner)
                .HasForeignKey(e => e.PartnerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PartnerType>()
                .HasMany(e => e.Partner)
                .WithRequired(e => e.PartnerType)
                .HasForeignKey(e => e.PartnerTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.PartnerProduct)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.ProductId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductType>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.ProductType)
                .HasForeignKey(e => e.ProductTypeId)
                .WillCascadeOnDelete(false);
        }
    }
}
