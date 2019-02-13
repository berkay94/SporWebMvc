using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SporWebMvc.Models
{
    [Table("Sporlar")]
    public class Sporlar:BaseEntity
    {
        [StringLength(50)]
        [DisplayName("Spor Adi")]
        public string SporAdi { get; set; }

        public int SporcuSayisi { get; set; }
    }
}