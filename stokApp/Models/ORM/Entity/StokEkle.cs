using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace stokApp.Models.ORM.Entity
{
    public class StokEkle : BaseEntity
    {
        public string Adi { get; set; }
        public int stokKod { get; set; }
        public string Birim { get; set; }

        private bool _stokTakip = false;//satış takibi yapılsın yapılmasın
        public bool StokTakip {
            get
            {
                return _stokTakip;
            }
            set
            {
                _stokTakip = value;
            }
        }

        public int Baslangicfiyat { get; set; }

        private bool _uyari = false;//bitmeye yakin uyari
        public bool Uyari
        {
            get
            {
                return _uyari;
            }
            set
            {
                _uyari = value;
            }
        }

        public int VergiHaricAlis { get; set; }
        public int VergiHaricSatis { get; set; }

        public int VergiDahilSatis { get; set; }
        public int VergiDahilAlis { get; set; }

        public int KDV { get; set; }
    }
}