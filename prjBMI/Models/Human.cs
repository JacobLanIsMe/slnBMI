using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBMI.Models
{
    public class Human : Animal
    {
        public override double GetBMI(double weight, double height)
        {
            return weight / (height / 100 * height / 100);
        }
    }
}
