using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.TretyakovDV.Sprint5.Task0.V9.Lib
{
    public class DataService : ISprint5Task0V0
    {

        public string SaveToFileTextData(int a, int b, int c)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double y = Math.Pow(a, 3) / (Math.Pow(b, 2) - c);
            y = Math.Round(y, 3);
            File.WriteAllText(path, Convert.ToString(y));
            return path;
        }
    }
}