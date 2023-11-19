﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.TretyakovDV.Sprint5.Task1.V18.Lib
{
    public class DataService : ISprint5Task1V0
    {

        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }


            double y;
            string strY;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Cos(x) + 1 == 0)
                { 
                    y = 0;
                    strY = Convert.ToString(y);
                }
                else
                {
                    y = 3 * x + 2 - ((2 * x - x) / (Math.Cos(x) + 1));
                    y = Math.Round(y, 2);
                    strY = Convert.ToString(y);
                }
                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }
            return path;
        }
    }
}