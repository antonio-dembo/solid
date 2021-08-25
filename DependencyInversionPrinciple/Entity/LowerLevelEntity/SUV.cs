using System;
using DependencyInversionPrinciple.Contract;

namespace DependencyInversionPrinciple.Entity.LowerLevelEntity
{
    // The rule is that the lower level entities should join the contract 
    // to a single interface.
    public class SUV : IAutomobile
    {
        #region IAutomobile members
        public void Ignition()
        {
            Console.WriteLine("SUV start");
        }

        public void Stop()
        {
            Console.WriteLine("SUV stopped.");
        }
        #endregion
    }
}