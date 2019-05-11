namespace TransportCompany
{
    abstract class WaterTransport : Transport
    {
        protected WaterTransport(uint speed, double carryingCapacity, string brand, uint numberOfStaff, 
            uint numberOfPassengers) : base(speed, carryingCapacity, brand, numberOfStaff, numberOfPassengers)
        {
        }

        protected WaterTransport(uint speed, double carryingCapacity) : base(speed, carryingCapacity)
        {
        }
        
        public override string ToString()
        {
            return GetType().Name + " WaterTransport " + base.ToString();
        }
    }
}