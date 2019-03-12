using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace stokApp.Models.ORM.Entity
{
    public class AlisTedarik : BaseEntity
    {
        public string FirmaUnvan { get; set; }
        public string Kisaisim { get; set; }
        public string Email { get; set; }
        public int TelNo  { get; set; }
        public int IBAN { get; set; }
        public string AcikAdres  { get; set; }
        public string ililce { get; set; }
        //Türü : Tüzel veya Gerçek Kişi Olup olmadığını sorgulamak
        public bool _tur = false;
        public bool Tur {
            get
            {
                return _tur;
            }
            set
            {
                _tur = value;

            }
        }
        public int TC { get; set; }
        public string Vd { get; set; }
        //Eğer Açılış Bakiyesi Varsa
        public int _bakiye = 0;
        public int bakiye {
            get
            {
                return _bakiye;
            }
            set
            {
                _bakiye = value;
            }
        }

        public int AlisFaturaID { get; set; }
        [ForeignKey("AlisFaturaID")]
        public virtual AlisFatura AlisFatura { get; set; }

    }
}