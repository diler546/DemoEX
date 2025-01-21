namespace Shuler_MasterPol.Models
{
    using Shuler_MasterPol.Services;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Partner")]
    public partial class Partner
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Partner()
        {
            PartnerProduct = new HashSet<PartnerProduct>();
        }

        private double GetAmount()
        {
            double sum = 0;
            foreach (PartnerProduct partnerProduct in PartnerProduct)
            {
                sum += partnerProduct.Amount;
            }
            return sum;
        }

        public bool isNew()
        {
            return IdPartner == 0;
        }


        public int Discout
        {
            get
            {
                double amount = GetAmount();
                return DiscountManager.CalculateDiscount(amount);
            }
        }

        [Key]
        public int IdPartner { get; set; }

        [Required]
        [StringLength(150)]
        public string PartnerName { get; set; }

        public int PartnerTypeId { get; set; }

        public int Rating { get; set; }

        [Required]
        [StringLength(150)]
        public string Address { get; set; }

        [Required]
        [StringLength(150)]
        public string Ceo { get; set; }

        public long Phone { get; set; }

        [Required]
        [StringLength(150)]
        public string Email { get; set; }

        [StringLength(150)]
        public string TaxpayerNumber { get; set; }

        public virtual PartnerType PartnerType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartnerProduct> PartnerProduct { get; set; }
    }
}
