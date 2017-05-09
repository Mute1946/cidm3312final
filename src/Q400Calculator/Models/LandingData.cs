using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Q400Calculator.Models
{
    public class LandingData
    {
        public int Id { get; set; }
        public int Weight { get; set; }

        [Display(Name = "Flaps")]
        public int Flaps { get; set; }

        [Display(Name = "V app")]
        public int Vapp { get; set; }

        [Display(Name = "V ref")]
        public int Vref { get; set; }

        [Display(Name = "V ga")]
        public int Vga { get; set; }
    }
}
