using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace stokApp.Models.ORM.Entity
{
    public class Musteri : BaseEntity //Müşteri ile Tedarikçi yapıları aynı
    {
        public string Unvan { get; set; }
        public string Isım { get; set; }
        public string Kategori { get; set; }//okana sor option's dan gelecek 
        public string email { get; set; }
        //[MaxLength(11)]
        public int TelNo { get; set; }
        public int IBAN { get; set; }
        public int Adres { get; set; }
        //[MaxLength(11)]
        public int TC { get; set; }
        public string VD { get; set; }
        public int AcilisBakiyesi { get; set; }//bunu Dışarı Kayıt edilecek muhtemelen

        //Tablo İlişkilendirilmesi

        public int TekliflerID { get; set; }
        [ForeignKey("TekliflerID")] 
        public virtual Teklifler Teklifler { get; set; }


    }
}