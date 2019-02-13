using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SporWebMvc.Models
{
    [Table("EtkinlikTipi")]
    public class EtkinlikTip:BaseEntity
    {
        [StringLength(50)]
        [DisplayName("Etkinlik Tipi")]
        public string Tip { get; set; }

        [StringLength(200)]
        [DisplayName("Aciklama")]
        public string Aciklama { get; set; }
    }
}