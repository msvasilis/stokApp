using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace stokApp.Models.ORM.Entity
{
    public class AdminUser : BaseEntity
    {
        public string Email  { get; set; }
        public string AdSoyad   { get; set; }
        public string FirmaAdi   { get; set; }
        public string TicUnvan  { get; set; }
        public string Sektor   { get; set; }
        public string Adres   { get; set; }
        public string ilIlce  { get; set; }
        [Required]
        //[MaxLength(11)]
        public int tc  { get; set; }
        public string VergiDaire  { get; set; }
    }
}