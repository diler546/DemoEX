namespace Shuler_MasterPol.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Material_type
    {
        [Key]
        public int IdMaterialType { get; set; }

        [Required]
        [StringLength(255)]
        public string MaterialTypeName { get; set; }

        public double DetectiveMaterialPercentage { get; set; }
    }
}
