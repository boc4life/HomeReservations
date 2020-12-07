using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using HomeReservations.Models;

namespace HomeReservations.DAL
{
    public class HomeReservationInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<HomeReservationContext>
    {
        protected override void Seed(HomeReservationContext context)
        {

            var unit1 = new Unit { Name = "Unit1", Description = "Beachside Condo" };
            var unit2 = new Unit { Name = "Unit2", Description = "Lakehouse" };
            var unit3 = new Unit { Name = "Unit3", Description = "Cozy Cottage" };
            var unit4 = new Unit { Name = "Unit4", Description = "Mountain Retreat" };
            var unit5 = new Unit { Name = "Unit5", Description = "Penthouse" };

            var admin1 = new Admin { Email = "test@email.com" };
            var admin2 = new Admin { Email = "newaccount@email.com" };
            var admin3 = new Admin { Email = "andrew@andrew.com" };

            unit1.Admins.Add(admin1);
            unit2.Admins.Add(admin1);
            unit3.Admins.Add(admin2);
            unit4.Admins.Add(admin2);
            unit4.Admins.Add(admin3);
            unit5.Admins.Add(admin3);

            var units = new List<Unit>();
            units.Add(unit1);
            units.Add(unit2);
            units.Add(unit3);
            units.Add(unit4);
            units.Add(unit5);

            var admins = new List<Admin>();
            admins.Add(admin1);
            admins.Add(admin2);
            admins.Add(admin3);

            units.ForEach(u => context.Units.Add(u));
            admins.ForEach(a => context.Admins.Add(a));
            context.SaveChanges();
        }
    }
}