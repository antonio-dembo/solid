using System;
using DependencyInversionPrinciple.Contract;
using DependencyInversionPrinciple.Entity.HigherLevelEntity;
using DependencyInversionPrinciple.Entity.LowerLevelEntity;

namespace DependencyInversionPrinciple
{
    public class Program
    {
        static void Main(string[] args)
        {
            IAutomobile automobile = new Jeep();
            //IAutomobile automobile = new SUV();
            AutomobileController automobileController = new AutomobileController(automobile);
            automobileController.Ignition();
            automobileController.Stop();

            Console.Read();

        }
    }
}
