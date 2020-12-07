using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HomeReservations.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace HomeReservations.DAL
{
    public class HomeReservationContext : DbContext
    {
        public HomeReservationContext() : base("HomeReservationContext")
        {
        }

        public DbSet<Unit> Units { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}