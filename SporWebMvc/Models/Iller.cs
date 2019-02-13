using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SporWebMvc.Models
{
    [Table("Iller")]
    public class Iller:BaseEntity
    {
        [StringLength(255)]
        [DisplayName("SehirIl")]
        public string Sehir { get; set; }
    }
}