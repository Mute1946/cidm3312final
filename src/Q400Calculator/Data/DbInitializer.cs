using Q400Calculator.Models;
using System;
using System.Linq;

namespace Q400Calculator.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();


            // Look for any Climb Data
            if (context.ClimbData.Any())
            {
                return;   // DB has been seeded
            }

            var climbtable = new ClimbData[]
            {
                    new ClimbData { Weight = 18000, Vfri5 = 116, Vfri10 = 110, Vfri15 = 107, Vclmb = 130 },
                    new ClimbData { Weight = 20000, Vfri5 = 120, Vfri10 = 112, Vfri15 = 109, Vclmb = 131 },
                    new ClimbData { Weight = 22000, Vfri5 = 126, Vfri10 = 180, Vfri15 = 115, Vclmb = 137 },
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

            // Look for any Takeoff Data
            if (context.TakeoffData.Any())
            {
                return;   // DB has been seeded
            }
            var takeofftable = new TakeoffData[]
            {

                    //Flap 5, Altitude 0, below
		            new TakeoffData { Flaps = 5, Weight = 18000, Above20 = false, Altitude = 0, Vr = 102, V2 = 116 },
                    new TakeoffData { Flaps = 5, Weight = 20000, Above20 = false, Altitude = 0, Vr = 105, V2 = 115 },
                    new TakeoffData { Flaps = 5, Weight = 22000, Above20 = false, Altitude = 0, Vr = 112, V2 = 117 },
                    new TakeoffData { Flaps = 5, Weight = 24000, Above20 = false, Altitude = 0, Vr = 118, V2 = 122 },
                    new TakeoffData { Flaps = 5, Weight = 26000, Above20 = false, Altitude = 0, Vr = 124, V2 = 127 },
                    new TakeoffData { Flaps = 5, Weight = 28000, Above20 = false, Altitude = 0, Vr = 130, V2 = 132 },
                    new TakeoffData { Flaps = 5, Weight = 29000, Above20 = false, Altitude = 0, Vr = 133, V2 = 135 },

                    //Flap 5, Altitude 2000, below
                    new TakeoffData { Flaps = 5, Weight = 18000, Above20 = false, Altitude = 2000, Vr = 102, V2 = 115 },
                    new TakeoffData { Flaps = 5, Weight = 20000, Above20 = false, Altitude = 2000, Vr = 106, V2 = 114 },
                    new TakeoffData { Flaps = 5, Weight = 22000, Above20 = false, Altitude = 2000, Vr = 113, V2 = 117 },
                    new TakeoffData { Flaps = 5, Weight = 24000, Above20 = false, Altitude = 2000, Vr = 119, V2 = 122 },
                    new TakeoffData { Flaps = 5, Weight = 26000, Above20 = false, Altitude = 2000, Vr = 125, V2 = 127 },
                    new TakeoffData { Flaps = 5, Weight = 28000, Above20 = false, Altitude = 2000, Vr = 131, V2 = 132 },
                    new TakeoffData { Flaps = 5, Weight = 29000, Above20 = false, Altitude = 2000, Vr = 134, V2 = 135 },

                    //Flap 5, Altitude 4000, below
                    new TakeoffData { Flaps = 5, Weight = 18000, Above20 = false, Altitude = 4000, Vr = 102, V2 = 115 },
                    new TakeoffData { Flaps = 5, Weight = 20000, Above20 = false, Altitude = 4000, Vr = 107, V2 = 114 },
                    new TakeoffData { Flaps = 5, Weight = 22000, Above20 = false, Altitude = 4000, Vr = 113, V2 = 117 },
                    new TakeoffData { Flaps = 5, Weight = 24000, Above20 = false, Altitude = 4000, Vr = 120, V2 = 122 },
                    new TakeoffData { Flaps = 5, Weight = 26000, Above20 = false, Altitude = 4000, Vr = 126, V2 = 127 },
                    new TakeoffData { Flaps = 5, Weight = 28000, Above20 = false, Altitude = 4000, Vr = 131, V2 = 132 },
                    new TakeoffData { Flaps = 5, Weight = 29000, Above20 = false, Altitude = 4000, Vr = 135, V2 = 135 }, 

                    //Flap 5, Altitude 6000, below
                    new TakeoffData { Flaps = 5, Weight = 18000, Above20 = false, Altitude = 6000, Vr = 102, V2 = 115 },
                    new TakeoffData { Flaps = 5, Weight = 20000, Above20 = false, Altitude = 6000, Vr = 107, V2 = 114 },
                    new TakeoffData { Flaps = 5, Weight = 22000, Above20 = false, Altitude = 6000, Vr = 113, V2 = 117 },
                    new TakeoffData { Flaps = 5, Weight = 24000, Above20 = false, Altitude = 6000, Vr = 120, V2 = 122 },
                    new TakeoffData { Flaps = 5, Weight = 26000, Above20 = false, Altitude = 6000, Vr = 126, V2 = 127 },
                    new TakeoffData { Flaps = 5, Weight = 28000, Above20 = false, Altitude = 6000, Vr = 131, V2 = 132 },
                    new TakeoffData { Flaps = 5, Weight = 29000, Above20 = false, Altitude = 6000, Vr = 135, V2 = 135 },

                    //Flap 5, Altitude 8000, below
                    new TakeoffData { Flaps = 5, Weight = 18000, Above20 = false, Altitude = 8000, Vr = 102, V2 = 112 },
                    new TakeoffData { Flaps = 5, Weight = 20000, Above20 = false, Altitude = 8000, Vr = 108, V2 = 112 },
                    new TakeoffData { Flaps = 5, Weight = 22000, Above20 = false, Altitude = 8000, Vr = 115, V2 = 117 },
                    new TakeoffData { Flaps = 5, Weight = 24000, Above20 = false, Altitude = 8000, Vr = 121, V2 = 122 },
                    new TakeoffData { Flaps = 5, Weight = 26000, Above20 = false, Altitude = 8000, Vr = 127, V2 = 127 },
                    new TakeoffData { Flaps = 5, Weight = 28000, Above20 = false, Altitude = 8000, Vr = 133, V2 = 132 },
                    new TakeoffData { Flaps = 5, Weight = 29000, Above20 = false, Altitude = 8000, Vr = 137, V2 = 135 },

                    //Flap 5, Altitude 10000, below
                    new TakeoffData { Flaps = 5, Weight = 18000, Above20 = false, Altitude = 10000, Vr = 103, V2 = 111 },
                    new TakeoffData { Flaps = 5, Weight = 20000, Above20 = false, Altitude = 10000, Vr = 110, V2 = 111 },
                    new TakeoffData { Flaps = 5, Weight = 22000, Above20 = false, Altitude = 10000, Vr = 116, V2 = 117 },
                    new TakeoffData { Flaps = 5, Weight = 24000, Above20 = false, Altitude = 10000, Vr = 122, V2 = 122 },
                    new TakeoffData { Flaps = 5, Weight = 26000, Above20 = false, Altitude = 10000, Vr = 128, V2 = 127 },
                    new TakeoffData { Flaps = 5, Weight = 28000, Above20 = false, Altitude = 10000, Vr = 134, V2 = 132 },
                    new TakeoffData { Flaps = 5, Weight = 29000, Above20 = false, Altitude = 10000, Vr = 138, V2 = 135 },
        
                    // ABOVE ////////////////////////////////////////////////////////////////////
                    //Flap 5, Altitude 0, above
                    new TakeoffData { Flaps = 5, Weight = 18000, Above20 = true, Altitude = 0, Vr = 102, V2 = 114 },
                    new TakeoffData { Flaps = 5, Weight = 20000, Above20 = true, Altitude = 0, Vr = 107, V2 = 113 },
                    new TakeoffData { Flaps = 5, Weight = 22000, Above20 = true, Altitude = 0, Vr = 113, V2 = 117 },
                    new TakeoffData { Flaps = 5, Weight = 24000, Above20 = true, Altitude = 0, Vr = 120, V2 = 122 },
                    new TakeoffData { Flaps = 5, Weight = 26000, Above20 = true, Altitude = 0, Vr = 126, V2 = 127 },
                    new TakeoffData { Flaps = 5, Weight = 28000, Above20 = true, Altitude = 0, Vr = 131, V2 = 132 },
                    new TakeoffData { Flaps = 5, Weight = 29000, Above20 = true, Altitude = 0, Vr = 135, V2 = 135 },
        
                    //Flap 5, Altitude 2000, above
                    new TakeoffData { Flaps = 5, Weight = 18000, Above20 = true, Altitude = 2000, Vr = 102, V2 = 113 },
                    new TakeoffData { Flaps = 5, Weight = 20000, Above20 = true, Altitude = 2000, Vr = 108, V2 = 112 },
                    new TakeoffData { Flaps = 5, Weight = 22000, Above20 = true, Altitude = 2000, Vr = 114, V2 = 117 },
                    new TakeoffData { Flaps = 5, Weight = 24000, Above20 = true, Altitude = 2000, Vr = 120, V2 = 122 },
                    new TakeoffData { Flaps = 5, Weight = 26000, Above20 = true, Altitude = 2000, Vr = 126, V2 = 127 },
                    new TakeoffData { Flaps = 5, Weight = 28000, Above20 = true, Altitude = 2000, Vr = 132, V2 = 132 },
                    new TakeoffData { Flaps = 5, Weight = 29000, Above20 = true, Altitude = 2000, Vr = 136, V2 = 135 },
        
                    //Flap 5, Altitude 4000, above
                    new TakeoffData { Flaps = 5, Weight = 18000, Above20 = true, Altitude = 4000, Vr = 102, V2 = 112 },
                    new TakeoffData { Flaps = 5, Weight = 20000, Above20 = true, Altitude = 4000, Vr = 108, V2 = 112 },
                    new TakeoffData { Flaps = 5, Weight = 22000, Above20 = true, Altitude = 4000, Vr = 115, V2 = 117 },
                    new TakeoffData { Flaps = 5, Weight = 24000, Above20 = true, Altitude = 4000, Vr = 121, V2 = 122 },
                    new TakeoffData { Flaps = 5, Weight = 26000, Above20 = true, Altitude = 4000, Vr = 127, V2 = 127 },
                    new TakeoffData { Flaps = 5, Weight = 28000, Above20 = true, Altitude = 4000, Vr = 133, V2 = 132 },
                    new TakeoffData { Flaps = 5, Weight = 29000, Above20 = true, Altitude = 4000, Vr = 137, V2 = 135 },
        
                    //Flap 5, Altitude 6000, above
                    new TakeoffData { Flaps = 5, Weight = 18000, Above20 = true, Altitude = 6000, Vr = 103, V2 = 111 },
                    new TakeoffData { Flaps = 5, Weight = 20000, Above20 = true, Altitude = 6000, Vr = 110, V2 = 111 },
                    new TakeoffData { Flaps = 5, Weight = 22000, Above20 = true, Altitude = 6000, Vr = 116, V2 = 117 },
                    new TakeoffData { Flaps = 5, Weight = 24000, Above20 = true, Altitude = 6000, Vr = 122, V2 = 122 },
                    new TakeoffData { Flaps = 5, Weight = 26000, Above20 = true, Altitude = 6000, Vr = 128, V2 = 127 },
                    new TakeoffData { Flaps = 5, Weight = 28000, Above20 = true, Altitude = 6000, Vr = 134, V2 = 132 },
                    new TakeoffData { Flaps = 5, Weight = 29000, Above20 = true, Altitude = 6000, Vr = 138, V2 = 135 },
        
                    //Flap 5, Altitude 8000, above
                    new TakeoffData { Flaps = 5, Weight = 18000, Above20 = true, Altitude = 8000, Vr = 103, V2 = 110 },
                    new TakeoffData { Flaps = 5, Weight = 20000, Above20 = true, Altitude = 8000, Vr = 110, V2 = 111 },
                    new TakeoffData { Flaps = 5, Weight = 22000, Above20 = true, Altitude = 8000, Vr = 117, V2 = 117 },
                    new TakeoffData { Flaps = 5, Weight = 24000, Above20 = true, Altitude = 8000, Vr = 123, V2 = 122 },
                    new TakeoffData { Flaps = 5, Weight = 26000, Above20 = true, Altitude = 8000, Vr = 129, V2 = 127 },
                    new TakeoffData { Flaps = 5, Weight = 28000, Above20 = true, Altitude = 8000, Vr = 135, V2 = 132 },
                    new TakeoffData { Flaps = 5, Weight = 29000, Above20 = true, Altitude = 8000, Vr = 138, V2 = 135 },
        
                    //Flap 5, Altitude 10000, above
                    new TakeoffData { Flaps = 5, Weight = 18000, Above20 = true, Altitude = 10000, Vr = 105, V2 = 109 },
                    new TakeoffData { Flaps = 5, Weight = 20000, Above20 = true, Altitude = 10000, Vr = 112, V2 = 111 },
                    new TakeoffData { Flaps = 5, Weight = 22000, Above20 = true, Altitude = 10000, Vr = 118, V2 = 117 },
                    new TakeoffData { Flaps = 5, Weight = 24000, Above20 = true, Altitude = 10000, Vr = 124, V2 = 122 },
                    new TakeoffData { Flaps = 5, Weight = 26000, Above20 = true, Altitude = 10000, Vr = 130, V2 = 127 },
                    new TakeoffData { Flaps = 5, Weight = 28000, Above20 = true, Altitude = 10000, Vr = 136, V2 = 132 },
                    new TakeoffData { Flaps = 5, Weight = 29000, Above20 = true, Altitude = 10000, Vr = 140, V2 = 135 },

        
                    // BELOW ////////////////////////////////////////////////////////////////////        
                    //Flap 10, Altitude 0, below
                    new TakeoffData { Flaps = 10, Weight = 18000, Above20 = false, Altitude = 0, Vr = 100, V2 = 111 },
                    new TakeoffData { Flaps = 10, Weight = 20000, Above20 = false, Altitude = 0, Vr = 100, V2 = 110 },
                    new TakeoffData { Flaps = 10, Weight = 22000, Above20 = false, Altitude = 0, Vr = 103, V2 = 109 },
                    new TakeoffData { Flaps = 10, Weight = 24000, Above20 = false, Altitude = 0, Vr = 109, V2 = 113 },
                    new TakeoffData { Flaps = 10, Weight = 26000, Above20 = false, Altitude = 0, Vr = 115, V2 = 118 },
                    new TakeoffData { Flaps = 10, Weight = 28000, Above20 = false, Altitude = 0, Vr = 120, V2 = 122 },
                    new TakeoffData { Flaps = 10, Weight = 29000, Above20 = false, Altitude = 0, Vr = 124, V2 = 125 },

                    //Flap 10, Altitude 2000, below
                    new TakeoffData { Flaps = 10, Weight = 18000, Above20 = false, Altitude = 2000, Vr = 100, V2 = 110 },
                    new TakeoffData { Flaps = 10, Weight = 20000, Above20 = false, Altitude = 2000, Vr = 100, V2 = 109 },
                    new TakeoffData { Flaps = 10, Weight = 22000, Above20 = false, Altitude = 2000, Vr = 105, V2 = 109 },
                    new TakeoffData { Flaps = 10, Weight = 24000, Above20 = false, Altitude = 2000, Vr = 110, V2 = 113 },
                    new TakeoffData { Flaps = 10, Weight = 26000, Above20 = false, Altitude = 2000, Vr = 116, V2 = 118 },
                    new TakeoffData { Flaps = 10, Weight = 28000, Above20 = false, Altitude = 2000, Vr = 121, V2 = 122 },
                    new TakeoffData { Flaps = 10, Weight = 29000, Above20 = false, Altitude = 2000, Vr = 125, V2 = 125 },

                    //Flap 10, Altitude 4000, below
                    new TakeoffData { Flaps = 10, Weight = 18000, Above20 = false, Altitude = 4000, Vr = 100, V2 = 110 },
                    new TakeoffData { Flaps = 10, Weight = 20000, Above20 = false, Altitude = 4000, Vr = 100, V2 = 109 },
                    new TakeoffData { Flaps = 10, Weight = 22000, Above20 = false, Altitude = 4000, Vr = 105, V2 = 108 },
                    new TakeoffData { Flaps = 10, Weight = 24000, Above20 = false, Altitude = 4000, Vr = 111, V2 = 113 },
                    new TakeoffData { Flaps = 10, Weight = 26000, Above20 = false, Altitude = 4000, Vr = 116, V2 = 118 },
                    new TakeoffData { Flaps = 10, Weight = 28000, Above20 = false, Altitude = 4000, Vr = 122, V2 = 122 },
                    new TakeoffData { Flaps = 10, Weight = 29000, Above20 = false, Altitude = 4000, Vr = 125, V2 = 125 }, 

                    //Flap 10, Altitude 6000, below
                    new TakeoffData { Flaps = 10, Weight = 18000, Above20 = false, Altitude = 6000, Vr = 100, V2 = 109 },
                    new TakeoffData { Flaps = 10, Weight = 20000, Above20 = false, Altitude = 6000, Vr = 100, V2 = 108 },
                    new TakeoffData { Flaps = 10, Weight = 22000, Above20 = false, Altitude = 6000, Vr = 105, V2 = 108 },
                    new TakeoffData { Flaps = 10, Weight = 24000, Above20 = false, Altitude = 6000, Vr = 111, V2 = 113 },
                    new TakeoffData { Flaps = 10, Weight = 26000, Above20 = false, Altitude = 6000, Vr = 117, V2 = 118 },
                    new TakeoffData { Flaps = 10, Weight = 28000, Above20 = false, Altitude = 6000, Vr = 122, V2 = 122 },
                    new TakeoffData { Flaps = 10, Weight = 29000, Above20 = false, Altitude = 6000, Vr = 126, V2 = 125 },

                    //Flap 10, Altitude 8000, below
                    new TakeoffData { Flaps = 10, Weight = 18000, Above20 = false, Altitude = 8000, Vr = 100, V2 = 108 },
                    new TakeoffData { Flaps = 10, Weight = 20000, Above20 = false, Altitude = 8000, Vr = 100, V2 = 107 },
                    new TakeoffData { Flaps = 10, Weight = 22000, Above20 = false, Altitude = 8000, Vr = 106, V2 = 108 },
                    new TakeoffData { Flaps = 10, Weight = 24000, Above20 = false, Altitude = 8000, Vr = 112, V2 = 113 },
                    new TakeoffData { Flaps = 10, Weight = 26000, Above20 = false, Altitude = 8000, Vr = 118, V2 = 118 },
                    new TakeoffData { Flaps = 10, Weight = 28000, Above20 = false, Altitude = 8000, Vr = 123, V2 = 122 },
                    new TakeoffData { Flaps = 10, Weight = 29000, Above20 = false, Altitude = 8000, Vr = 127, V2 = 125 },

                    //Flap 10, Altitude 10000, below
                    new TakeoffData { Flaps = 10, Weight = 18000, Above20 = false, Altitude = 10000, Vr = 100, V2 = 107 },
                    new TakeoffData { Flaps = 10, Weight = 20000, Above20 = false, Altitude = 10000, Vr = 101, V2 = 106 },
                    new TakeoffData { Flaps = 10, Weight = 22000, Above20 = false, Altitude = 10000, Vr = 108, V2 = 108 },
                    new TakeoffData { Flaps = 10, Weight = 24000, Above20 = false, Altitude = 10000, Vr = 113, V2 = 113 },
                    new TakeoffData { Flaps = 10, Weight = 26000, Above20 = false, Altitude = 10000, Vr = 119, V2 = 118 },
                    new TakeoffData { Flaps = 10, Weight = 28000, Above20 = false, Altitude = 10000, Vr = 124, V2 = 122 },
                    new TakeoffData { Flaps = 10, Weight = 29000, Above20 = false, Altitude = 10000, Vr = 128, V2 = 125 },
        
                    // ABOVE ////////////////////////////////////////////////////////////////////
                    //Flap 10, Altitude 0, above
                    new TakeoffData { Flaps = 10, Weight = 18000, Above20 = true, Altitude = 0, Vr = 100, V2 = 109 },
                    new TakeoffData { Flaps = 10, Weight = 20000, Above20 = true, Altitude = 0, Vr = 100, V2 = 108 },
                    new TakeoffData { Flaps = 10, Weight = 22000, Above20 = true, Altitude = 0, Vr = 104, V2 = 108 },
                    new TakeoffData { Flaps = 10, Weight = 24000, Above20 = true, Altitude = 0, Vr = 110, V2 = 113 },
                    new TakeoffData { Flaps = 10, Weight = 26000, Above20 = true, Altitude = 0, Vr = 116, V2 = 118 },
                    new TakeoffData { Flaps = 10, Weight = 28000, Above20 = true, Altitude = 0, Vr = 121, V2 = 122 },
                    new TakeoffData { Flaps = 10, Weight = 29000, Above20 = true, Altitude = 0, Vr = 125, V2 = 125 },
        
                    //Flap 10, Altitude 2000, above
                    new TakeoffData { Flaps = 10, Weight = 18000, Above20 = true, Altitude = 2000, Vr = 100, V2 = 109 },
                    new TakeoffData { Flaps = 10, Weight = 20000, Above20 = true, Altitude = 2000, Vr = 100, V2 = 108 },
                    new TakeoffData { Flaps = 10, Weight = 22000, Above20 = true, Altitude = 2000, Vr = 106, V2 = 108 },
                    new TakeoffData { Flaps = 10, Weight = 24000, Above20 = true, Altitude = 2000, Vr = 111, V2 = 113 },
                    new TakeoffData { Flaps = 10, Weight = 26000, Above20 = true, Altitude = 2000, Vr = 117, V2 = 118 },
                    new TakeoffData { Flaps = 10, Weight = 28000, Above20 = true, Altitude = 2000, Vr = 122, V2 = 122 },
                    new TakeoffData { Flaps = 10, Weight = 29000, Above20 = true, Altitude = 2000, Vr = 125, V2 = 125 },
        
                    //Flap 10, Altitude 4000, above
                    new TakeoffData { Flaps = 10, Weight = 18000, Above20 = true, Altitude = 4000, Vr = 100, V2 = 109 },
                    new TakeoffData { Flaps = 10, Weight = 20000, Above20 = true, Altitude = 4000, Vr = 100, V2 = 107 },
                    new TakeoffData { Flaps = 10, Weight = 22000, Above20 = true, Altitude = 4000, Vr = 106, V2 = 108 },
                    new TakeoffData { Flaps = 10, Weight = 24000, Above20 = true, Altitude = 4000, Vr = 112, V2 = 113 },
                    new TakeoffData { Flaps = 10, Weight = 26000, Above20 = true, Altitude = 4000, Vr = 117, V2 = 118 },
                    new TakeoffData { Flaps = 10, Weight = 28000, Above20 = true, Altitude = 4000, Vr = 123, V2 = 122 },
                    new TakeoffData { Flaps = 10, Weight = 29000, Above20 = true, Altitude = 4000, Vr = 126, V2 = 125 },
        
                    //Flap 10, Altitude 6000, above
                    new TakeoffData { Flaps = 10, Weight = 18000, Above20 = true, Altitude = 6000, Vr = 100, V2 = 107 },
                    new TakeoffData { Flaps = 10, Weight = 20000, Above20 = true, Altitude = 6000, Vr = 100, V2 = 106 },
                    new TakeoffData { Flaps = 10, Weight = 22000, Above20 = true, Altitude = 6000, Vr = 106, V2 = 108 },
                    new TakeoffData { Flaps = 10, Weight = 24000, Above20 = true, Altitude = 6000, Vr = 112, V2 = 113 },
                    new TakeoffData { Flaps = 10, Weight = 26000, Above20 = true, Altitude = 6000, Vr = 118, V2 = 118 },
                    new TakeoffData { Flaps = 10, Weight = 28000, Above20 = true, Altitude = 6000, Vr = 123, V2 = 122 },
                    new TakeoffData { Flaps = 10, Weight = 29000, Above20 = true, Altitude = 6000, Vr = 127, V2 = 125 },
        
                    //Flap 10, Altitude 8000, above
                    new TakeoffData { Flaps = 10, Weight = 18000, Above20 = true, Altitude = 8000, Vr = 100, V2 = 106 },
                    new TakeoffData { Flaps = 10, Weight = 20000, Above20 = true, Altitude = 8000, Vr = 100, V2 = 105 },
                    new TakeoffData { Flaps = 10, Weight = 22000, Above20 = true, Altitude = 8000, Vr = 106, V2 = 108 },
                    new TakeoffData { Flaps = 10, Weight = 24000, Above20 = true, Altitude = 8000, Vr = 112, V2 = 113 },
                    new TakeoffData { Flaps = 10, Weight = 26000, Above20 = true, Altitude = 8000, Vr = 118, V2 = 118 },
                    new TakeoffData { Flaps = 10, Weight = 28000, Above20 = true, Altitude = 8000, Vr = 123, V2 = 122 },
                    new TakeoffData { Flaps = 10, Weight = 29000, Above20 = true, Altitude = 8000, Vr = 127, V2 = 125 },
        
                    //Flap 10, Altitude 10000, above
                    new TakeoffData { Flaps = 10, Weight = 18000, Above20 = true, Altitude = 10000, Vr = 100, V2 = 105 },
                    new TakeoffData { Flaps = 10, Weight = 20000, Above20 = true, Altitude = 10000, Vr = 100, V2 = 105 },
                    new TakeoffData { Flaps = 10, Weight = 22000, Above20 = true, Altitude = 10000, Vr = 106, V2 = 108 },
                    new TakeoffData { Flaps = 10, Weight = 24000, Above20 = true, Altitude = 10000, Vr = 112, V2 = 113 },
                    new TakeoffData { Flaps = 10, Weight = 26000, Above20 = true, Altitude = 10000, Vr = 118, V2 = 118 },
                    new TakeoffData { Flaps = 10, Weight = 28000, Above20 = true, Altitude = 10000, Vr = 123, V2 = 122 },
                    new TakeoffData { Flaps = 10, Weight = 29000, Above20 = true, Altitude = 10000, Vr = 127, V2 = 125 },        
        
                    // BELOW ////////////////////////////////////////////////////////////////////        
                    //Flap 15, Altitude 0, below
                    new TakeoffData { Flaps = 15, Weight = 18000, Above20 = false, Altitude = 0, Vr =  98, V2 = 106 },
                    new TakeoffData { Flaps = 15, Weight = 20000, Above20 = false, Altitude = 0, Vr =  98, V2 = 105 },
                    new TakeoffData { Flaps = 15, Weight = 22000, Above20 = false, Altitude = 0, Vr = 100, V2 = 104 },
                    new TakeoffData { Flaps = 15, Weight = 24000, Above20 = false, Altitude = 0, Vr = 106, V2 = 109 },
                    new TakeoffData { Flaps = 15, Weight = 26000, Above20 = false, Altitude = 0, Vr = 111, V2 = 113 },
                    new TakeoffData { Flaps = 15, Weight = 28000, Above20 = false, Altitude = 0, Vr = 116, V2 = 118 },
                    new TakeoffData { Flaps = 15, Weight = 29000, Above20 = false, Altitude = 0, Vr = 119, V2 = 120 },

                    //Flap 15, Altitude 2000, below
                    new TakeoffData { Flaps = 15, Weight = 18000, Above20 = false, Altitude = 2000, Vr =  98, V2 = 106 },
                    new TakeoffData { Flaps = 15, Weight = 20000, Above20 = false, Altitude = 2000, Vr =  98, V2 = 105 },
                    new TakeoffData { Flaps = 15, Weight = 22000, Above20 = false, Altitude = 2000, Vr = 101, V2 = 104 },
                    new TakeoffData { Flaps = 15, Weight = 24000, Above20 = false, Altitude = 2000, Vr = 106, V2 = 109 },
                    new TakeoffData { Flaps = 15, Weight = 26000, Above20 = false, Altitude = 2000, Vr = 112, V2 = 113 },
                    new TakeoffData { Flaps = 15, Weight = 28000, Above20 = false, Altitude = 2000, Vr = 117, V2 = 118 },
                    new TakeoffData { Flaps = 15, Weight = 29000, Above20 = false, Altitude = 2000, Vr = 120, V2 = 120 },

                    //Flap 15, Altitude 4000, below
                    new TakeoffData { Flaps = 15, Weight = 18000, Above20 = false, Altitude = 4000, Vr =  98, V2 = 105 },
                    new TakeoffData { Flaps = 15, Weight = 20000, Above20 = false, Altitude = 4000, Vr =  98, V2 = 104 },
                    new TakeoffData { Flaps = 15, Weight = 22000, Above20 = false, Altitude = 4000, Vr = 101, V2 = 104 },
                    new TakeoffData { Flaps = 15, Weight = 24000, Above20 = false, Altitude = 4000, Vr = 107, V2 = 109 },
                    new TakeoffData { Flaps = 15, Weight = 26000, Above20 = false, Altitude = 4000, Vr = 112, V2 = 113 },
                    new TakeoffData { Flaps = 15, Weight = 28000, Above20 = false, Altitude = 4000, Vr = 117, V2 = 118 },
                    new TakeoffData { Flaps = 15, Weight = 29000, Above20 = false, Altitude = 4000, Vr = 120, V2 = 120 }, 

                    //Flap 15, Altitude 6000, below
                    new TakeoffData { Flaps = 15, Weight = 18000, Above20 = false, Altitude = 6000, Vr =  98, V2 = 104 },
                    new TakeoffData { Flaps = 15, Weight = 20000, Above20 = false, Altitude = 6000, Vr =  98, V2 = 103 },
                    new TakeoffData { Flaps = 15, Weight = 22000, Above20 = false, Altitude = 6000, Vr = 102, V2 = 104 },
                    new TakeoffData { Flaps = 15, Weight = 24000, Above20 = false, Altitude = 6000, Vr = 108, V2 = 109 },
                    new TakeoffData { Flaps = 15, Weight = 26000, Above20 = false, Altitude = 6000, Vr = 113, V2 = 113 },
                    new TakeoffData { Flaps = 15, Weight = 28000, Above20 = false, Altitude = 6000, Vr = 118, V2 = 118 },
                    new TakeoffData { Flaps = 15, Weight = 29000, Above20 = false, Altitude = 6000, Vr = 121, V2 = 120 },

                    //Flap 15, Altitude 8000, below
                    new TakeoffData { Flaps = 15, Weight = 18000, Above20 = false, Altitude = 8000, Vr =  98, V2 = 103 },
                    new TakeoffData { Flaps = 15, Weight = 20000, Above20 = false, Altitude = 8000, Vr =  98, V2 = 102 },
                    new TakeoffData { Flaps = 15, Weight = 22000, Above20 = false, Altitude = 8000, Vr = 103, V2 = 104 },
                    new TakeoffData { Flaps = 15, Weight = 24000, Above20 = false, Altitude = 8000, Vr = 108, V2 = 109 },
                    new TakeoffData { Flaps = 15, Weight = 26000, Above20 = false, Altitude = 8000, Vr = 114, V2 = 113 },
                    new TakeoffData { Flaps = 15, Weight = 28000, Above20 = false, Altitude = 8000, Vr = 118, V2 = 118 },
                    new TakeoffData { Flaps = 15, Weight = 29000, Above20 = false, Altitude = 8000, Vr = 122, V2 = 120 },

                    //Flap 15, Altitude 10000, below
                    new TakeoffData { Flaps = 15, Weight = 18000, Above20 = false, Altitude = 10000, Vr =  98, V2 = 102 },
                    new TakeoffData { Flaps = 15, Weight = 20000, Above20 = false, Altitude = 10000, Vr =  98, V2 = 102 },
                    new TakeoffData { Flaps = 15, Weight = 22000, Above20 = false, Altitude = 10000, Vr = 104, V2 = 104 },
                    new TakeoffData { Flaps = 15, Weight = 24000, Above20 = false, Altitude = 10000, Vr = 109, V2 = 109 },
                    new TakeoffData { Flaps = 15, Weight = 26000, Above20 = false, Altitude = 10000, Vr = 114, V2 = 113 },
                    new TakeoffData { Flaps = 15, Weight = 28000, Above20 = false, Altitude = 10000, Vr = 119, V2 = 118 },
                    new TakeoffData { Flaps = 15, Weight = 29000, Above20 = false, Altitude = 10000, Vr = 122, V2 = 120 },
        
                    // ABOVE ////////////////////////////////////////////////////////////////////
                    //Flap 15, Altitude 0, above
                    new TakeoffData { Flaps = 15, Weight = 18000, Above20 = true, Altitude = 0, Vr =  98, V2 = 105 },
                    new TakeoffData { Flaps = 15, Weight = 20000, Above20 = true, Altitude = 0, Vr =  98, V2 = 103 },
                    new TakeoffData { Flaps = 15, Weight = 22000, Above20 = true, Altitude = 0, Vr = 101, V2 = 104 },
                    new TakeoffData { Flaps = 15, Weight = 24000, Above20 = true, Altitude = 0, Vr = 107, V2 = 109 },
                    new TakeoffData { Flaps = 15, Weight = 26000, Above20 = true, Altitude = 0, Vr = 112, V2 = 113 },
                    new TakeoffData { Flaps = 15, Weight = 28000, Above20 = true, Altitude = 0, Vr = 117, V2 = 118 },
                    new TakeoffData { Flaps = 15, Weight = 29000, Above20 = true, Altitude = 0, Vr = 120, V2 = 120 },
        
                    //Flap 15, Altitude 2000, above
                    new TakeoffData { Flaps = 15, Weight = 18000, Above20 = true, Altitude = 2000, Vr =  98, V2 = 104 },
                    new TakeoffData { Flaps = 15, Weight = 20000, Above20 = true, Altitude = 2000, Vr =  98, V2 = 103 },
                    new TakeoffData { Flaps = 15, Weight = 22000, Above20 = true, Altitude = 2000, Vr = 102, V2 = 104 },
                    new TakeoffData { Flaps = 15, Weight = 24000, Above20 = true, Altitude = 2000, Vr = 108, V2 = 109 },
                    new TakeoffData { Flaps = 15, Weight = 26000, Above20 = true, Altitude = 2000, Vr = 113, V2 = 113 },
                    new TakeoffData { Flaps = 15, Weight = 28000, Above20 = true, Altitude = 2000, Vr = 118, V2 = 118 },
                    new TakeoffData { Flaps = 15, Weight = 29000, Above20 = true, Altitude = 2000, Vr = 121, V2 = 120 },
        
                    //Flap 15, Altitude 4000, above
                    new TakeoffData { Flaps = 15, Weight = 18000, Above20 = true, Altitude = 4000, Vr =  98, V2 = 103 },
                    new TakeoffData { Flaps = 15, Weight = 20000, Above20 = true, Altitude = 4000, Vr =  98, V2 = 102 },
                    new TakeoffData { Flaps = 15, Weight = 22000, Above20 = true, Altitude = 4000, Vr = 103, V2 = 104 },
                    new TakeoffData { Flaps = 15, Weight = 24000, Above20 = true, Altitude = 4000, Vr = 108, V2 = 109 },
                    new TakeoffData { Flaps = 15, Weight = 26000, Above20 = true, Altitude = 4000, Vr = 114, V2 = 113 },
                    new TakeoffData { Flaps = 15, Weight = 28000, Above20 = true, Altitude = 4000, Vr = 119, V2 = 118 },
                    new TakeoffData { Flaps = 15, Weight = 29000, Above20 = true, Altitude = 4000, Vr = 121, V2 = 120 },
        
                    //Flap 15, Altitude 6000, above
                    new TakeoffData { Flaps = 15, Weight = 18000, Above20 = true, Altitude = 6000, Vr =  98, V2 = 102 },
                    new TakeoffData { Flaps = 15, Weight = 20000, Above20 = true, Altitude = 6000, Vr =  98, V2 = 102 },
                    new TakeoffData { Flaps = 15, Weight = 22000, Above20 = true, Altitude = 6000, Vr = 104, V2 = 104 },
                    new TakeoffData { Flaps = 15, Weight = 24000, Above20 = true, Altitude = 6000, Vr = 109, V2 = 109 },
                    new TakeoffData { Flaps = 15, Weight = 26000, Above20 = true, Altitude = 6000, Vr = 114, V2 = 113 },
                    new TakeoffData { Flaps = 15, Weight = 28000, Above20 = true, Altitude = 6000, Vr = 119, V2 = 118 },
                    new TakeoffData { Flaps = 15, Weight = 29000, Above20 = true, Altitude = 6000, Vr = 122, V2 = 120 },
        
                    //Flap 15, Altitude 8000, above
                    new TakeoffData { Flaps = 15, Weight = 18000, Above20 = true, Altitude = 8000, Vr =  98, V2 = 102 },
                    new TakeoffData { Flaps = 15, Weight = 20000, Above20 = true, Altitude = 8000, Vr =  98, V2 = 102 },
                    new TakeoffData { Flaps = 15, Weight = 22000, Above20 = true, Altitude = 8000, Vr = 104, V2 = 104 },
                    new TakeoffData { Flaps = 15, Weight = 24000, Above20 = true, Altitude = 8000, Vr = 110, V2 = 109 },
                    new TakeoffData { Flaps = 15, Weight = 26000, Above20 = true, Altitude = 8000, Vr = 115, V2 = 113 },
                    new TakeoffData { Flaps = 15, Weight = 28000, Above20 = true, Altitude = 8000, Vr = 120, V2 = 118 },
                    new TakeoffData { Flaps = 15, Weight = 29000, Above20 = true, Altitude = 8000, Vr = 123, V2 = 120 },
        
                    //Flap 15, Altitude 10000, above
                    new TakeoffData { Flaps = 15, Weight = 18000, Above20 = true, Altitude = 10000, Vr =  98, V2 = 102 },
                    new TakeoffData { Flaps = 15, Weight = 20000, Above20 = true, Altitude = 10000, Vr =  98, V2 = 102 },
                    new TakeoffData { Flaps = 15, Weight = 22000, Above20 = true, Altitude = 10000, Vr = 104, V2 = 104 },
                    new TakeoffData { Flaps = 15, Weight = 24000, Above20 = true, Altitude = 10000, Vr = 110, V2 = 109 },
                    new TakeoffData { Flaps = 15, Weight = 26000, Above20 = true, Altitude = 10000, Vr = 115, V2 = 113 },
                    new TakeoffData { Flaps = 15, Weight = 28000, Above20 = true, Altitude = 10000, Vr = 120, V2 = 118 },
                    new TakeoffData { Flaps = 15, Weight = 29000, Above20 = true, Altitude = 10000, Vr = 123, V2 = 120 },
            };
            foreach (TakeoffData td in takeofftable)
            {
                context.TakeoffData.Add(td);
            }


            // Look for any Landing Data
            if (context.LandingData.Any())
            {
                return;   // DB has been seeded
            }
            var landingtable = new LandingData[]
            {
                    //Flaps 5
                    new LandingData { Weight = 18000, Flaps = 5, Vapp = 115, Vref = 115, Vga = 109 },
                    new LandingData { Weight = 20000, Flaps = 5, Vapp = 120, Vref = 120, Vga = 110 },
                    new LandingData { Weight = 22000, Flaps = 5, Vapp = 126, Vref = 126, Vga = 115 },
                    new LandingData { Weight = 24000, Flaps = 5, Vapp = 131, Vref = 131, Vga = 120 },
                    new LandingData { Weight = 26000, Flaps = 5, Vapp = 137, Vref = 137, Vga = 125 },
                    new LandingData { Weight = 28000, Flaps = 5, Vapp = 142, Vref = 142, Vga = 130 },
                    new LandingData { Weight = 29000, Flaps = 5, Vapp = 146, Vref = 146, Vga = 134 },

                    //Flaps 10
                    new LandingData { Weight = 18000, Flaps = 10, Vapp = 109, Vref = 108, Vga = 108 },
                    new LandingData { Weight = 20000, Flaps = 10, Vapp = 112, Vref = 112, Vga = 108 },
                    new LandingData { Weight = 22000, Flaps = 10, Vapp = 117, Vref = 117, Vga = 108 },
                    new LandingData { Weight = 24000, Flaps = 10, Vapp = 122, Vref = 122, Vga = 112 },
                    new LandingData { Weight = 26000, Flaps = 10, Vapp = 127, Vref = 127, Vga = 117 },
                    new LandingData { Weight = 28000, Flaps = 10, Vapp = 132, Vref = 132, Vga = 122 },
                    new LandingData { Weight = 29000, Flaps = 10, Vapp = 136, Vref = 136, Vga = 125 },

                    //Flaps 15
                    new LandingData { Weight = 18000, Flaps = 15, Vapp = 106, Vref = 105, Vga = 105 },
                    new LandingData { Weight = 20000, Flaps = 15, Vapp = 106, Vref = 106, Vga = 105 },
                    new LandingData { Weight = 22000, Flaps = 15, Vapp = 112, Vref = 112, Vga = 105 },
                    new LandingData { Weight = 24000, Flaps = 15, Vapp = 117, Vref = 117, Vga = 107 },
                    new LandingData { Weight = 26000, Flaps = 15, Vapp = 122, Vref = 121, Vga = 111 },
                    new LandingData { Weight = 28000, Flaps = 15, Vapp = 126, Vref = 126, Vga = 116 },
                    new LandingData { Weight = 29000, Flaps = 15, Vapp = 129, Vref = 129, Vga = 119 },

                    //Flaps 35
                    new LandingData { Weight = 18000, Flaps = 35, Vapp = 101, Vref = 101, Vga = 101 },
                    new LandingData { Weight = 20000, Flaps = 35, Vapp = 102, Vref = 102, Vga = 102 },
                    new LandingData { Weight = 22000, Flaps = 35, Vapp = 107, Vref = 107, Vga = 107 },
                    new LandingData { Weight = 24000, Flaps = 35, Vapp = 112, Vref = 112, Vga = 112 },
                    new LandingData { Weight = 26000, Flaps = 35, Vapp = 116, Vref = 116, Vga = 116 },
                    new LandingData { Weight = 28000, Flaps = 35, Vapp = 120, Vref = 120, Vga = 120 },
                    new LandingData { Weight = 29000, Flaps = 35, Vapp = 123, Vref = 123, Vga = 123 },
                };
            foreach (LandingData ld in landingtable)
            {
                context.LandingData.Add(ld);
            }

            context.SaveChanges();
        }
    }
}
