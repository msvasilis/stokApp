using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace stokApp.Models.ORM.Entity
{
    public class Teklifler : BaseEntity
    {
        public string TeklifAciklama  { get; set; }
        public DateTime DuzenTarih { get; set; }
        public DateTime VadeTarih { get; set; }

        public virtual List<Musteri> Musteris { get; set; }

        public int HizmetID { get; set; }
        [ForeignKey("HizmetID")]
        public virtual Hizmet Hizmet { get; set; }
    }
}