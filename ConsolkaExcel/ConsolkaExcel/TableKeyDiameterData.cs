using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolkaExcel
{
    class TableKeyDiameterData
    {

        public List<float> _hightMM = new List<float> { 1100, 1200, 1400, 1500, 1600, 1800, 2000, 2200, 2400, 2500, 2600, 2800, 3000, 3200, 3500, 3600, 4000, 4200 };

        public List<float> _value2000mmHight = new List<float> { 6,6,6,8,8,9,10,10,12,12,12,15,15,15,16,16,18,18};

        public List<float> _value10000mmHight = new List<float> { 8, 8, 8, 10, 10, 11, 13, 13, 15, 15, 15, 18, 18, 18, 19, 19, 22, 22};

        public List<double> _baseThickness = new List<double> { 7.03, 7.03, 7.03, 9.03, 9.03, 10.03, 11.54, 11.54, 13.54, 13.54, 13.54, 16.54, 16.54, 16.54, 17.54, 17.54, 20.05, 20.05};

        public List<double> _labourIntensity = new List<double> { 0, 1.00, 1.00, 1.00, 1.00, 1.00, 1.00, 1.00, 0.90, 0.90, 0.90, 0.90, 0.90, 0.90, 0.90, 0.90, 1.00, 1.00 };

        public List<float> _bracnesQuantity = new List<float> { 8, 8, 8, 8, 8, 12, 12, 12, 12, 12, 12, 12, 12, 12, 16, 16, 24, 24};
    }
}
