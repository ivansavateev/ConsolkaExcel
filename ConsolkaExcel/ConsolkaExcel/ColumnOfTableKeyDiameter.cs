using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolkaExcel
{
    class ColumnOfTableKeyDiameter
    {        
        public float HightMM { get; set; }

        public float Value2000mmHight { get; set; }

        public float Value10000mmHight { get; set; }

        public double BaseThickness { get; set; }

        public double LabourIntensity { get; set; }

        public float BracnesQuantity { get; set; }

        public ColumnOfTableKeyDiameter(float hightMM, float value2000mmHight, float value10000mmHight, double baseThickness, double labourIntensity, float bracnesQuantity)
        {
            HightMM = hightMM;
            Value2000mmHight = value2000mmHight;
            Value10000mmHight = value10000mmHight;
            BaseThickness = baseThickness;
            LabourIntensity = labourIntensity;
            BracnesQuantity = bracnesQuantity;}

    }

    
}
