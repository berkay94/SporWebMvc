using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SporWebMvc.Models
{
    [Table("Ilceler")]
    public class Ilceler:BaseEntity
    {
        [StringLength(255)]
        [DisplayName("Ad")]
        public string Ad { get; set; }

        public int? Sehir { get; set; }

        [DisplayName("SehirIlce")]
        [ForeignKey("Sehir")]
        public virtual Iller IlceSehir { get; set; }
    }
}