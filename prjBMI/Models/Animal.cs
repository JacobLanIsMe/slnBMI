using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBMI.Models
{
    public class Animal
    {
        public double Weight { get; set; }
        public double Height { get; set; }
        public virtual double minBMIValue { get; set; }
        public virtual double maxBMIValue { get; set; }
        public virtual double GetBMI(double weight, double height) { return 0; }
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
