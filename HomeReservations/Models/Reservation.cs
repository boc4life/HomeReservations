using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeReservations.Models
{
    public class Reservation
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public int UnitID { get; set; }

        public virtual Unit Unit { get; set; }
    }
}