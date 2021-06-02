using System;

namespace SingleResponsabilityPrinciple
{
    public class GarageStation
    {
        private IGarageUtility _garageUtil;

        public GarageStation (IGarageUtility GarageSUtil)
        {
            _garageUtil = GarageSUtil;
        }
        
        public void OpenForService()
        {
            _garageUtil.OpenGate();            
        }

        public void DoService(Vehicle Vehicle)
        {
            // check if service station is open and then
            // finish the vehicle service
        }

        public void CloseGarage()
        {
            _garageUtil.CloseGate();
        }

    }

    public interface IGarageUtility
    {
        void OpenGate();
        void CloseGate();   
    }

    public class GarageStationUtility : IGarageUtility
    {
        public void OpenGate()
        {
            Console.WriteLine("Open the gate functionality.");
        }

        public void CloseGate()
        {
            Console.WriteLine("Close the gate functionality.");
        }
    }

}