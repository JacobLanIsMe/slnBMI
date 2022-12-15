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
        public static int GetUserSpeciesOrGender<T>(string query)
        {
            int count = 0;
            string[] enumNames = Enum.GetNames(typeof(T));
            string queryString = $"請選擇你的{query}(";
            foreach (string enumName in enumNames)
            {
                count++;
                queryString += $"{count}: {enumName}, ";
            }
            queryString = queryString.Trim(new Char[] { ',', ' ' });
            queryString += "):";
            int number = 0;
            bool isInRange = false;
            while (!isInRange)
            {
                Console.WriteLine(queryString);
                bool isCorrectedFormat = Int32.TryParse(Console.ReadLine(), out number);
                if (isCorrectedFormat)
                {
                    if (number > 0 && number <= enumNames.Length)
                    {
                        isInRange = true;
                    }
                }
            }
            return number;
        }
        //判斷身高和體重個輸入格式是否為正數數字的方法
        public static double GetUserWeightOrHeight(string query)
        {
            bool isCorrectedFormat = false;
            bool isFirst = true;
            double number = 0;
            while (!isCorrectedFormat)
            {
                if (!isFirst)
                {
                    Console.WriteLine("請輸入正數數字\n");
                }
                Console.WriteLine(query);
                isCorrectedFormat = (double.TryParse(Console.ReadLine(), out number) && number > 0);
                isFirst = false;
            }
            return number;
        }
        //提供所有物種+性別的組合
        public static BMIAndResult GetSpecies(string speciesGenderName, double weight, double height)
        {
            
            Animal animal = null;
            switch (speciesGenderName)
            {
                case "ChickenMale":
                    animal = new ChickenMale();
                    break;
                case "ChickenFemale":
                    animal = new ChickenFemale();
                    break;
                case "DogMale":
                    animal = new DogMale();
                    break;
                case "DogFemale":
                    animal = new DogFemale();
                    break;
                case "PigMale":
                    animal = new PigMale();
                    break;
                case "PigFemale":
                    animal = new PigFemale();
                    break;
                case "HumanMale":
                    animal = new HumanMale();
                    break;
                case "HumanFemale":
                    animal = new HumanFemale();
                    break;
            }
            double bmi = animal.GetBMI(weight,height);
            string result = animal.GetResult(bmi, animal.minBMIValue, animal.maxBMIValue);
            BMIAndResult bMIAndResult = new BMIAndResult()
            {
                BMI = bmi,
                result = result,
            };
            return bMIAndResult;
        }

    }



}
