﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KultyshevaEA.Sprint3.Task0.V24.Lib
{
    public class DataService : ISprint3Task0V24
    {
        public double GetSumSeries(double value)
        {
            double sumSeries = 0;
            int i;
            for (i=1;i<=7;i++)
            {
                sumSeries = sumSeries + Math.Pow((3 / (i + (Math.Pow(value, -i)))), 2);
            }
            return Math.Round(sumSeries, 3);
        }
    }
}