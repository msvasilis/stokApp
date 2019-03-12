using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace stokApp.Models.ORM.Entity
{
    public class SatisFatura : BaseEntity
    {
        public string Aciklama { get; set; }

        private bool _irsaliye = false;
        public bool irsaliye {
            get
            {
                return _irsaliye;
            }
            set
            {
                _irsaliye = value;
            }
        }

        public DateTime DuzenTarih { get; set; }
        public int FaturaNo { get; set; }
        private bool _odemeDurum = false;
        public bool OdemeDurum {
            get
            {
                return _odemeDurum;
            }
            set
            {
                _odemeDurum = value;

            }
        }

        public int HizmetID { get; set; }
        [ForeignKey("HizmetID")]
        public virtual Hizmet Hizmet { get; set; }
    }
}