using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SporWebMvc.Models
{
    [Table("Etkinlik")]
    public class Etkinlikler:BaseEntity
    { 
        [StringLength(50)]
        [DisplayName("Etkinlik Adi")]
        public string EtkinlikAdi { get; set; }

        public int? TipId { get; set; }

        [DisplayName("Etkinlik")]
        [ForeignKey("TipId")]
        public virtual EtkinlikTip EtkinlikTip { get; set; }

        public int MekanId { get; set; }

        [DisplayName("Etlkinlik Tarihi")]
        [DataType(DataType.Date)]
        public DateTime EtkinlikTarihi { get; set; }

        public int Kontenjan { get; set; }

        public int isActive { get; set; }

        public int Sid { get; set; }
    }
}