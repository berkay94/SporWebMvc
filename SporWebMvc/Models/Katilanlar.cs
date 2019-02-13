using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SporWebMvc.Models
{
    [Table("Katilanlar")]
    public class Katilanlar
    {
        [Key]
        [Column(Order =1)]
        public int Eid { get; set; }

        [ForeignKey("Eid")]
        public virtual Etkinlikler Etkinlikler { get; set;}

        [Key]
        [Column(Order =2)]
        public int Kid { get; set; }

        [ForeignKey("Kid")]
        public virtual Kullanici Kullanicilar { get; set; }
    }
}