using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SporWebMvc.Models
{
    [Table("Mekan")]
    public class Mekan:BaseEntity
    {
        [StringLength(50)]
        [DisplayName("Mekan Ad")]
        public string MekanAdi { get; set; }

        public int? IlceId { get; set; }

        [DisplayName("Mekan")]
        [ForeignKey("IlceId")]
        public virtual Ilceler Ilceler { get; set; }
    }
}