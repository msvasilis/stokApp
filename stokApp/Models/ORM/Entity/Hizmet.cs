using System.Collections.Generic;

namespace stokApp.Models.ORM.Entity
{
    public class Hizmet : BaseEntity
    {//Oluşturulan fatura içerisinde stok ürünü daha önce girilmemişse buraya uğraması gerekiyor
        public string HizmetAdi { get; set; }
        public int Miktari { get; set; }
        public int BirimFiyati { get; set; }
        public int Vergi { get; set; }//kdv Orani
        public int Toplam { get; set; }

        public  virtual List<Teklifler> Tekliflers { get; set; }
        public  virtual List<faturalar> Faturalars { get; set; }
        public  virtual List<SatisFatura> SatisFaturas { get; set; }
    }
}