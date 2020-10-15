using System;
using System.Collections.Generic;
using System.Text;

namespace ConsolkaExcel
{
    class PumpStation
    {
        public static Dictionary<float, TableKeyDiameter> TableKeyDiameter = new Dictionary<float, TableKeyDiameter>();

        private float _diameterMillimeters; //Опросник D5

        private double _hight; // Н КНС, м Расчет С11

        private float _buriedPumpsQuantity = 2; // Насос погружной Опросник F16
                                                //насосов всегда на 1 больше так как один рабочий а другой хз

        private float _quantityStartingPerHour; // Количество влючений в час Опросник F17

        private double _totalDischarge;// Общий расход л/с или м*3/час опросник D23

        private float _depthToUndegroundSpaceMM; // H до лотка входной трубы Опросник C9

        private double _minDepthToUndergroundSpaceMM; //H min погружения насоса Опросник D17

        private static float _insalationMM; //Утепление  Опросник D7s

        private double _volumeOfWork; // Vраб, м³ расчет C6

        private double _areaOfSection; // S cечения КНС, м² Расчет C7

        private double _depthOfDelveM; //H приямка, мs Расчет C8

        private double _distanceToInputPipeMM; //глубина до лотка H Опросник D10

        private double _volume; // объем КНС, м³ Расчет С12

        private double _averageWallsThickness;

        private double _mass;

        public double Volume => _volume;
        public double Hight => _hight;
        public float DiameterMillimeters
        {
            get
            {
                return _diameterMillimeters;
            }
            set
            {
                if(value % 100 == 0 && value >= 1100 && value <= 4200)
                {
                    _diameterMillimeters = value;
                }
            }
        }
        
        public float BodyQuantity = 1; //Количество корпусов опросник F5
        public float QuantityStartingPerHour => _quantityStartingPerHour;

        public bool _unitIsLitresPerHour; // л/сек или м*3/час опросник EF23 
        public double TotalDischarge
        {
            get
            {
                return _totalDischarge;
            }

            set
            {
                if (_unitIsLitresPerHour)
                {
                    _totalDischarge = value * 3.6;
                }
                _totalDischarge = value;
            }
        }
        public float DepthToUndegroundSpaceMM => _depthToUndegroundSpaceMM;
        public double MinDepthToUndergroundSpaceMM => _minDepthToUndergroundSpaceMM;
        public double VolumeOfWork => _volumeOfWork;
        public double AreaOfSection => _areaOfSection;
        public double DepthOfDelveM => _depthOfDelveM;
        public double DistanceToInputPipeMM => _distanceToInputPipeMM;
        public double AverageWallsThickness => _averageWallsThickness;
        public double Mass => _mass;



        public void SetQuantityStartingPerHour(float quantityStartingPerHour)
        {
            _quantityStartingPerHour = quantityStartingPerHour;
        }
        public double SetVolumeOfWork()
        {
            return _volumeOfWork = TotalDischarge / (4 * (_buriedPumpsQuantity - 1) * _quantityStartingPerHour); //насосов всегда на 1 больше так как один рабочий а другой хз
        }

        public void SetAreaOfSection() 
        {
            float temp = Utilities.ConvertValueMMtoM(_diameterMillimeters);
            _areaOfSection = Math.PI * Math.Pow(temp, 2) / 4;            
        }

        public void SetDepthOfDelveM()
        {
            if (_volumeOfWork == 0 && _totalDischarge != 0) throw new Exception("_volumeOfWork == 0");
            //если totalDischarge равен 0, значит обе ячейки totalDischarge == 0 и _volumeOfWork == 0
            //но если totalDischarge равен какому то значению, а _volumeOfWork нет
            //значит у нас проблемы и вылетит эксепшн
            if (_areaOfSection == 0) throw new Exception("_areaOfSection == 0");
            if (BodyQuantity == 0) throw new Exception("BodyQuantity == 0");
            if (_totalDischarge == 0)
            {
                _depthOfDelveM = 0;
            }
            else
            {
                if (_diameterMillimeters <= 2000)
                {
                    _depthOfDelveM = _volumeOfWork / _areaOfSection / BodyQuantity + 0.2;
                }
                else
                {
                    _depthOfDelveM = _volumeOfWork / _areaOfSection / BodyQuantity + 0.3;
                }
            }

        }

        public void SetDistanceToInputPipeMM(double distanceToInputPipe)
        {
            _distanceToInputPipeMM = distanceToInputPipe;
        }

        public void SetMinDepthToUndergroundSpaceMM(double minDepthToUndergroundSpaceMM)
        {
            _minDepthToUndergroundSpaceMM = minDepthToUndergroundSpaceMM;
        }

        public void SetHight()
        {
            _hight = Math.Round(DepthOfDelveM + Utilities.ConvertValueMMtoM(DistanceToInputPipeMM) + Utilities.ConvertValueMMtoM(MinDepthToUndergroundSpaceMM),2);
        }

        public void SetVolume()
        {
           _volume = _areaOfSection * Hight;
        }

        public void SetAverageWallsThickness()
        {            
            foreach(KeyValuePair<float, TableKeyDiameter> value in TableKeyDiameter)
            {
                if(value.Key == _diameterMillimeters)
                {
                    _averageWallsThickness = Utilities.ConvertValueMMtoM (value.Value.BaseThickness);
                }                
            }            
        }

        public void SetMass()
        {
            _mass = Math.PI * Utilities.ConvertValueMMtoM( _diameterMillimeters * _hight * _averageWallsThickness + _areaOfSection);//дописать
        }
    }
}
