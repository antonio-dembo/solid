using DependencyInversionPrinciple.Contract;

namespace DependencyInversionPrinciple.Entity.HigherLevelEntity
{
    // and the higher-level entities will use only entities that are implementing 
    // the interface.
    public class AutomobileController
    {
        private IAutomobile m_automobile;

        public AutomobileController(IAutomobile automobile)
        {
            this.m_automobile = automobile;
        }

        public void Ignition()
        {
            m_automobile.Ignition();
        }

        public void Stop()
        {
            m_automobile.Stop();
        }
    }
}