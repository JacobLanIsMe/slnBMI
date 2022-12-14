using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBMI.Models
{
    public abstract class Dog : Animal
    {
        public override double GetBMI(double weight, double height)
        {
            return weight / (height / 2);
        }
    }
}
