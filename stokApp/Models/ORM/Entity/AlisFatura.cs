using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace stokApp.Models.ORM.Entity
{
    public class AlisFatura : BaseEntity
    {
        public string Aciklama { get; set; }
        public DateTime FisTarih { get; set; }
        public int ToplamTutar { get; set; }
        public int KDV { get; set; }
        //Ödeme Durumu ile ilgili Kolon oluşturunca ekle
        
        public virtual List<AlisTedarik> AlisTedariks { get; set; }
    }
}