using System;

namespace SingleResponsabilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            IGarageUtility garageUtil = new GarageStationUtility();
            GarageStation garageStation = new GarageStation(garageUtil);
            Vehicle vehicle = new Vehicle();

            garageUtil.OpenGate();
            garageStation.DoService(vehicle);
            garageUtil.CloseGate();
            
        }
    }
}
