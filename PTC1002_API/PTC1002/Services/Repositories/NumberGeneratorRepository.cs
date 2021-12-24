using Microsoft.AspNetCore.Mvc;
using PTC1002.Dtos;
using PTC1002.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PTC1002.Services.Repositories
{
    public class NumberGeneratorRepository : INumberGeneratorRepository
    {
        public RandomNumberDto GenerateRandomNumber(string fileSize)
        {
            RandomNumberDto randomNumberDto = new RandomNumberDto();

            if (fileSize != null && fileSize != "undefined" && fileSize != "0")
            {
                FileInfo fi = new FileInfo(Path.Combine(Directory.GetCurrentDirectory(), "MyTextFile.txt"));
                if (Convert.ToInt64(fileSize) * 1024 <= fi.Length)
                {
                    randomNumberDto.NumCounter = 0;
                    randomNumberDto.AlphaCounter = 0;
                    randomNumberDto.FloatCounter = 0;
                    randomNumberDto.FileSize = fi.Length;
                    return randomNumberDto;
                }
            }

            Random rand = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            int numericVal = rand.Next();
            float floatVal = (float)(float.MaxValue * 2.0 * (rand.NextDouble() - 0.5));

            string alphanumericeVal = new string(Enumerable.Repeat(chars, 5).Select(s => s[rand.Next(s.Length)]).ToArray());
            using (StreamWriter outputFile = File.AppendText(Path.Combine(Directory.GetCurrentDirectory(), "MyTextFile.txt")))
            {
                outputFile.Write(string.Format("Numeric: {0} , Alphanumeric: {1}, Float: {2},", numericVal, alphanumericeVal, floatVal));

            }

            FileInfo fiNew = new FileInfo(Path.Combine(Directory.GetCurrentDirectory(), "MyTextFile.txt"));
            randomNumberDto.NumCounter = 1;
            randomNumberDto.AlphaCounter = 1;
            randomNumberDto.FloatCounter = 1;
            randomNumberDto.FileSize = fiNew.Length;
            return randomNumberDto;



        } 
        public List<ReportRandomNumberDto> ViewRandomNumberReport()
        {
            List<ReportRandomNumberDto> randomNumberDto = new List<ReportRandomNumberDto>();


            var listVal = System.IO.File.ReadAllText("MyTextFile.txt");
            List<string> allVal = listVal.Split(',').ToList<string>();
            var numericVal = allVal
    .Where(stringToCheck => stringToCheck.Contains("Numeric: ")).ToList();
            float numericValperct =  ((float)numericVal.Count() / (float)allVal.Count()) * 100;
           numericVal = numericVal.Select(x => x.Replace("Numeric: ", "")).Take(20).ToList();
            var floatVal = allVal
    .Where(stringToCheck => stringToCheck.Contains("Float: ")).ToList();

            float floatValperct = ((float)floatVal.Count() / (float)allVal.Count()) * 100;
            floatVal = floatVal.Select(x => x.Replace("Float: ", "")).Take(20).ToList();
            var alphaVal = allVal
    .Where(stringToCheck => stringToCheck.Contains("Alphanumeric: ")).ToList();

            float alphaValperct = ((float)alphaVal.Count() / (float)allVal.Count()) * 100;
            alphaVal = alphaVal.Select(x => x.Replace("Alphanumeric: ", "")).Take(20).ToList();
           
            for (int i = 0; i < 20; i++)
            {
                ReportRandomNumberDto r = new ReportRandomNumberDto();

                r.AlphaNumeric = alphaVal[i];
                r.Float = float.Parse(floatVal[i]);
                r.Numeric = Convert.ToInt32(numericVal[i]);
                r.NumericPerct = numericValperct;
                r.FloatPerct = floatValperct;
                r.AlphaNumericPerct = alphaValperct;

                randomNumberDto.Add(r);
            }
            return randomNumberDto;



        }
    }
}
