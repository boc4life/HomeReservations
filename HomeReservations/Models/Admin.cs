using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeReservations.Models
{
    public class Admin
    {
        public Admin()
        {
            this.Units = new HashSet<Unit>();
        }

        public int ID { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Unit> Units { get; set; }
    }
}