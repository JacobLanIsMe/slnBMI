using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBMI.Models
{
    public class Pig : Animal
    {
        public override double GetBMI(double weight, double height)
        {
            return weight * 2 / (height / 100 * height / 100);
        }
    }
}
