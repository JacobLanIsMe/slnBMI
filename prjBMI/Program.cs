using prjBMI;
using prjBMI.Enums;
using prjBMI.Models;
using prjBMI.Services;

//判斷物種格式是否正確
int species = 0;
GetBMIService.IsCorrectedSpeciesAndGenderFormat<ESpecies>("物種", out species);
//判斷性別格式是否正確
int gender = 0;
GetBMIService.IsCorrectedSpeciesAndGenderFormat<EGender>("性別", out gender);

double height = 0;
double weight = 0;
GetBMIService.IsCorrectedWeightAndHeightFormat("請輸入您的身高(cm):", out height); //判斷身高格式是否為正數數字
GetBMIService.IsCorrectedWeightAndHeightFormat("請輸入您的體重(kg):", out weight); //判斷體重格式是否為正數數字
Console.WriteLine($"您的物種為 {(ESpecies)species}，您的性別為 {(EGender)gender}，身高: {height}cm，體重: {weight}kg");

//判斷男女性並求出BMI和結果
string speciesGenderName = ((ESpecies)species).ToString() + ((EGender)gender).ToString();
BMIAndResult BMIAndResult = GetBMIService.GetSpecies(speciesGenderName, weight, height);
string bmi = BMIAndResult.BMI.ToString("0.00");
string result = BMIAndResult.result;
Console.WriteLine($"BMI值: {bmi}，{result}");

