using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Q400Calculator.Models
{
    public class TakeoffData
    {
        public int Id { get; set; }
        public int Weight { get; set; }

        public int Altitude { get; set; }

        [Display(Name = "Flaps")]
        public int Flaps { get; set; }

        [Display(Name = "VR")]
        public int Vr { get; set; }

        [Display(Name = "V2")]
        public int V2 { get; set; }

        [Display(Name = "Above20")]
        public bool Above20 { get; set; }



        /* Tried to use the V1 and V2 but couldn't
         * get since it was called in the first Flaps
        [Display(Name = "Flaps 10 Below 20C")]
        //public int V1 { get; set; }
        // public int V2 { get; set; }

        [Display(Name = "Flaps 15 Below 20C")]
        //public int Vfri15 { get; set; }

        [Display(Name = "Flaps 5 Above 20C")]
        //public int Vclmb { get; set; }*/

    }
}
