using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolkaExcel
{
    class TestRepositories
    {
        public static void SetDiamaterValue(PumpStation pumpStation, float newValue)
        {
            pumpStation.DiameterMillimeters = newValue;       
        }
    }
}
