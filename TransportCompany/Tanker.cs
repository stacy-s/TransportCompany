namespace TransportCompany
{
    class Tanker : WaterTransport
    {
        public Tanker(uint speed, double carryingCapacity, string brand, uint numberOfStaff, 
            uint numberOfPassengers) : base(speed, carryingCapacity, brand, numberOfStaff, numberOfPassengers)
        {
        }

        public Tanker(uint speed, double carryingCapacity) : base(speed, carryingCapacity)
        {
        }
    }
}