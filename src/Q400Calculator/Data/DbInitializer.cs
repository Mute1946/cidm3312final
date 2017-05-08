using Q400Calculator.Models;
using System;
using System.Linq;

namespace Q400Calculator.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.ClimbData.Any())
            {
                return;   // DB has been seeded
            }

            var climbtable = new ClimbData[]
            {
                new ClimbData { Weight = 18000, Vfri5 = 116, Vfri10 = 110, Vfri15 = 107, Vclmb = 130 },
                new ClimbData { Weight = 20000, Vfri5 = 120, Vfri10 = 112, Vfri15 = 109, Vclmb = 131 },
                new ClimbData { Weight = 22000, Vfri5 = 126, Vfri10 = 118, Vfri15 = 115, Vclmb = 137 },
                new ClimbData { Weight = 24000, Vfri5 = 132, Vfri10 = 123, Vfri15 = 120, Vclmb = 143 },
                new ClimbData { Weight = 26000, Vfri5 = 137, Vfri10 = 128, Vfri15 = 125, Vclmb = 148 },
                new ClimbData { Weight = 28000, Vfri5 = 142, Vfri10 = 134, Vfri15 = 130, Vclmb = 154 },
                new ClimbData { Weight = 29000, Vfri5 = 146, Vfri10 = 137, Vfri15 = 133, Vclmb = 158 },

            };
            foreach (ClimbData cd in climbtable)
            {
                context.ClimbData.Add(cd);
            }
            context.SaveChanges();
        }
    }
}