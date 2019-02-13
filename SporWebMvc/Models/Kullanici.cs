using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SporWebMvc.Models
{
    [Table("Kullanici")]
    public class Kullanici:BaseEntity
    {
        [StringLength(50)]
        [DisplayName("Ad")]
        public string Ad { get; set; }

        [StringLength(50)]
        [DisplayName("Soyad")]
        public string Soyad { get; set; }

        [StringLength(50)]
        [DisplayName("Email")]
        public string Email { get; set; }

        [StringLength(50)]
        [DisplayName("Telefon")]
        public string Telefon { get; set; }

        [StringLength(10)]
        [DisplayName("Sifre")]
        public char Sifre { get; set; }

        [StringLength(50)]
        [DisplayName("Ilce")]
        public string Ilce { get; set; }

        [DisplayName("Dogum Tarihi")]
        [DataType(DataType.Date)]
        public DateTime DogumTarihi { get; set; }

        public int Cinsiyet { get; set; }

        public int isLogin { get; set; }


    }
}