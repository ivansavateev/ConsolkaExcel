using System;

namespace ConsolkaExcel
{
    class Program
    {
        static TestRepositories testObject = new TestRepositories();
        static void Main(string[] args)
        {
            PumpStation PumpStation = new PumpStation();
            TableKeyDiameter access = new TableKeyDiameter();
            TestRepositories.SetDiamaterValue(PumpStation, 2600);
            PumpStation.SetQuantityStartingPerHour(15);
            PumpStation._unitIsLitresPerHour = false;
            PumpStation.TotalDischarge = 700;
            PumpStation.SetAreaOfSection();
            PumpStation.SetVolumeOfWork();
            PumpStation.SetDepthOfDelveM();
            PumpStation.SetDistanceToInputPipeMM(2000);
            PumpStation.SetMinDepthToUndergroundSpaceMM(1600);
            PumpStation.SetHight();
            PumpStation.SetVolume();
            access.Initializing();
            PumpStation.SetAverageWallsThickness();

            //DepthOfDelveM DepthToUndegroundSpaceMM MinDepthToUndergroundSpaceMM




            Console.WriteLine(PumpStation.AverageWallsThickness);
        }


    }
}
