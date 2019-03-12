using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace stokApp.Models.ORM.Entity
{
    public class BaseEntity
    {
        public int ID { get; set; }
        private DateTime _addDate = DateTime.Now;
        public DateTime dateTime
        {
            get
            {
                return _addDate;
            }
            set
            {
                _addDate = value;
            }
        }
        private bool _isDelete = false;
        public bool IsDelete  {
            get {
                return _isDelete;
            }
            set
            {
                _isDelete = value;
            }
        }
        public DateTime? DeleteTime  { get; set; }
    }
}