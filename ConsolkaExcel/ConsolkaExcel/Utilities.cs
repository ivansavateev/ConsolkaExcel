using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolkaExcel
{
    class Utilities
    {
        public static double ConvertValueMMtoM(double diameterMM)
        {
            return diameterMM / 1000;
        }

        public static float ConvertValueMMtoM(float diameterMM)
        {
            return diameterMM / 1000;
        }
    }
}
