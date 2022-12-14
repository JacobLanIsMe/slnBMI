using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBMI.Models
{
    public abstract class Animal
    {
        public double Weight { get; set; }
        public double Height { get; set; }
        public abstract double GetBMI(double weight, double height);
        public string GetResult(double bmi, double minBMIValue, double maxBMIValue)
        {
            if (bmi > maxBMIValue)
            {
                return ("太胖");
            }
            else if (bmi >= minBMIValue)
            {
                return ("適中");
            }
            else
            {
                return ("太瘦");
            }
        }
    }
}
