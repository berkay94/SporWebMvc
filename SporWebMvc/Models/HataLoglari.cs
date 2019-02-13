using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SporWebMvc.Models
{
    [Table("HataLoglari")]
    public class HataLoglari:BaseEntity
    {
        [StringLength(200)]
        [DisplayName("Dosya Adi")]
        public string DosyaAdi { get; set; }

        [StringLength(200)]
        [DisplayName("Method Adi")]
        public string MethodAdi { get; set; }

        public int LineNumber { get; set; }

        public int ColumnNumber { get; set; }

        [StringLength(200)]
        [DisplayName("Mesaj")]
        public string Message { get; set; }

        [DisplayName("Tarih")]
        [DataType(DataType.Date)]
        public DateTime Trh { get; set; }
    }
}