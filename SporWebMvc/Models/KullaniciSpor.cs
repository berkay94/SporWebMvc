using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SporWebMvc.Models
{
    [Table("KullaniciSpor")]
    public class KullaniciSpor
    {
        [Key]
        [Column(Order = 1)]
        public int Kid { get; set; }

        [ForeignKey("Kid")]
        public virtual Kullanici Kullanicilar { get; set; }

        [Key]
        [Column(Order = 2)]
        public int Sid { get; set; }

        [ForeignKey("Sid")]
        public virtual Sporlar Sporlar { get; set; }
    }
}