using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBMI.Models
{
    public class PigFemale : Pig
    {
        public override double minBMIValue { get; set; } = 18;
        public override double maxBMIValue { get; set; } = 22;
    }
}
