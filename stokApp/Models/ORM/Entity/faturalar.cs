using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace stokApp.Models.ORM.Entity
{
    public class faturalar:BaseEntity
    {
        public string FaturaAciklama  { get; set; }
        private bool _irsaliye = false;
        public bool Irsaliye
        {
            get //irsaliyeli Fatura ise 
                //(Sevkiyatı Fatura ile yapılan satış, stok çıkışı fatura ile yapılır
            {
                return _irsaliye;
            }
            set //Sevkiyat gerektirmeyen ya da 
                //sevkiyatı daha sonra yapılacak satış. Stok çıkışı yapılmaz.
            {
                _irsaliye = value;
            }
        }
        public DateTime DuzenTarih { get; set; }
        public int seri { get; set; }
        public int sıra { get; set; }

        public virtual List<Musteri> Musteris{ get; set; }

        public int HizmetID { get; set; }
        [ForeignKey("HizmetID")]
        public virtual Hizmet Hizmet { get; set; }
    }
}