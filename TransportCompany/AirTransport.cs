namespace TransportCompany
{
    abstract class AirTransport : Transport
    {
        protected AirTransport(uint speed, double carryingCapacity, string brand, uint numberOfStaff, 
            uint numberOfPassengers) : base(speed, carryingCapacity, brand, numberOfStaff, numberOfPassengers)
        {
        }

        protected AirTransport(uint speed, double carryingCapacity) : base(speed, carryingCapacity)
        {
        }
        
        public override string ToString()
        {
            return GetType().Name + " AirTransport " + base.ToString();
        }
    }
}