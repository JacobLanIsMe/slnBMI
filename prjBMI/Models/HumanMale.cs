using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBMI.Models
{
    public class HumanMale : Human
    {
        public override double minBMIValue { get; set; } = 20;
        public override double maxBMIValue { get; set; } = 25;
    }
}
