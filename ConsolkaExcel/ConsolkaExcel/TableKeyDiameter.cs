using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolkaExcel
{
    class TableKeyDiameter
    {
        
        private float[] _hightMM = new float[18] { 1100, 1200, 1400, 1500, 1600, 1800, 2000, 2200, 2400, 2500, 2600, 2800, 3000, 3200, 3500, 3600, 4000, 4200 };

        private float[] _value2000mmHight = new float[18] { 6,6,6,8,8,9,10,10,12,12,12,15,15,15,16,16,18,18};

        private float[] _value10000mmHight = new float[18] { 8, 8, 8, 10, 10, 11, 13, 13, 15, 15, 15, 18, 18, 18, 19, 19, 22, 22};

        private double[] _baseThickness = new double[18] { 7.03, 7.03, 7.03, 9.03, 9.03, 10.03, 11.54, 11.54, 13.54, 13.54, 13.54, 16.54, 16.54, 16.54, 17.54, 17.54, 20.05, 20.05};

        private double[] _labourIntensity = new double[18] { 0, 1.00, 1.00, 1.00, 1.00, 1.00, 1.00, 1.00, 0.90, 0.90, 0.90, 0.90, 0.90, 0.90, 0.90, 0.90, 1.00, 1.00 };

        private float[] _bracnesQuantity = new float[18] { 8, 8, 8, 8, 8, 12, 12, 12, 12, 12, 12, 12, 12, 12, 16, 16, 24, 24};

        public float HightMM;

        public float Value2000mmHight;

        public float Value10000mmHight;

        public double BaseThickness;

        public double LabourIntensity;

        public float BracnesQuantity;


        public void Initializing()
        {
            for(int i = 0; i < _hightMM.Length; i++)                
           PumpStation.TableKeyDiameter.Add(_hightMM[i], new TableKeyDiameter
            {
               HightMM = _hightMM[i],
               Value2000mmHight = _value2000mmHight[i],
               Value10000mmHight = _value10000mmHight[i],
               BaseThickness = _baseThickness[i],
               LabourIntensity = _labourIntensity[i],
               BracnesQuantity = _bracnesQuantity[i]
            });
        }
    }
}
