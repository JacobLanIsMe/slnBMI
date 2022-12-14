using prjBMI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBMI.Services
{
    public class GetBMIService
    {
        //產生物種和性別的選項並判斷格式是否正確的方法
        public static void IsCorrectedSpeciesAndGenderFormat<T>(string query, out int number)
        {
            int count = 0;
            string queryString = $"請選擇你的{query}(";
            foreach (string enumName in Enum.GetNames(typeof(T)))
            {
                count++;
                queryString += $"{count}: {enumName}, ";
            }
            queryString = queryString.Trim(new Char[] { ',', ' ' });
            queryString += "):";
            bool isCorrectedFormat = false;
            number = 0;
            bool isInRange = false;
            do
            {
                isInRange = false;
                Console.WriteLine(queryString);
                isCorrectedFormat = Int32.TryParse(Console.ReadLine(), out number);
                if (isCorrectedFormat)
                {
                    if (number > 0 && number <= count)
                    {
                        isInRange = true;
                    }
                }
            }
            while (!isInRange);
        }
        //判斷身高和體重個輸入格式是否為正數數字的方法
        public static void IsCorrectedWeightAndHeightFormat(string query, out double number)
        {
            bool isCorrectedFormat = false;
            int count = 0;
            do
            {
                if (count != 0)
                {
                    Console.WriteLine("請輸入正數數字\n");
                }
                Console.WriteLine(query);
                isCorrectedFormat = (double.TryParse(Console.ReadLine(), out number) && number > 0);
                count++;
            }
            while (!isCorrectedFormat);
        }
        //提供所有物種+性別的組合
        public static BMIAndResult GetSpecies(string speciesGenderName, double weight, double height)
        {
            double bmi = 0;
            string result = "";
            switch (speciesGenderName)
            {
                case "ChickenMale":
                    ChickenMale chickenMale = new ChickenMale();
                    bmi = chickenMale.GetBMI(weight, height);
                    result = chickenMale.GetResult(bmi, chickenMale.minBMIValue, chickenMale.maxBMIValue);
                    break;
                case "ChickenFemale":
                    ChickenFemale chickenFemale = new ChickenFemale();
                    bmi = chickenFemale.GetBMI(weight, height);
                    result = chickenFemale.GetResult(bmi, chickenFemale.minBMIValue, chickenFemale.maxBMIValue);
                    break;
                case "DogMale":
                    DogMale dogMale = new DogMale();
                    bmi = dogMale.GetBMI(weight, height);
                    result = dogMale.GetResult(bmi, dogMale.minBMIValue, dogMale.maxBMIValue);
                    break;
                case "DogFemale":
                    DogFemale dogFemale = new DogFemale();
                    bmi = dogFemale.GetBMI(weight, height);
                    result = dogFemale.GetResult(bmi, dogFemale.minBMIValue, dogFemale.maxBMIValue);
                    break;
                case "PigMale":
                    PigMale pigMale = new PigMale();
                    bmi = pigMale.GetBMI(weight, height);
                    result = pigMale.GetResult(bmi, pigMale.minBMIValue, pigMale.maxBMIValue);
                    break;
                case "PigFemale":
                    PigFemale pigFemale = new PigFemale();
                    bmi = pigFemale.GetBMI(weight, height);
                    result = pigFemale.GetResult(bmi, pigFemale.minBMIValue, pigFemale.maxBMIValue);
                    break;
                case "HumanMale":
                    HumanMale humanMale = new HumanMale();
                    bmi = humanMale.GetBMI(weight, height);
                    result = humanMale.GetResult(bmi, humanMale.minBMIValue, humanMale.maxBMIValue);
                    break;
                case "HumanFemale":
                    HumanFemale humanFemale = new HumanFemale();
                    bmi = humanFemale.GetBMI(weight, height);
                    result = humanFemale.GetResult(bmi, humanFemale.minBMIValue, humanFemale.maxBMIValue);
                    break;
            }
            BMIAndResult bMIAndResult = new BMIAndResult()
            {
                BMI = bmi,
                result = result,
            };
            return bMIAndResult;
        }

    }



}
