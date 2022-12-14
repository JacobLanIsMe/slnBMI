using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBMI.Models
{
    public class Chicken : Animal
    {
        public override double GetBMI(double weight, double height)
        {
            return weight / (height * height);
        }
    }
}
