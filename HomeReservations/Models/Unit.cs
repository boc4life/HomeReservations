using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeReservations.Models
{
    public class Unit
    {
        public Unit()
        {
            this.Admins = new HashSet<Admin>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Admin> Admins { get; set; }
    }
}