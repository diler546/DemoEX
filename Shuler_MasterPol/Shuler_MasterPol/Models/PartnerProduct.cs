namespace Shuler_MasterPol.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PartnerProduct")]
    public partial class PartnerProduct
    {
        [Key]
        public int IdPartnerProduct { get; set; }

        public int ProductId { get; set; }

        public int PartnerId { get; set; }

        public double Amount { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public virtual Partner Partner { get; set; }

        public virtual Product Product { get; set; }
    }
}
