using System;
using DependencyInversionPrinciple.Contract;

namespace DependencyInversionPrinciple.Entity.LowerLevelEntity
{
    // The rule is that the lower level entities should join the contract 
    // to a single interface.
    public class Jeep : IAutomobile
    {
        #region IAutomobile members
        public void Ignition()
        {
            Console.WriteLine("Jeep started.");
        }

        public void Stop()
        {
            Console.WriteLine("Jeep stoped.");
        }

        #endregion
    }
}