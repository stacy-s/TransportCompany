namespace TransportCompany
{
    class Liner : WaterTransport
    {
        public Liner(uint speed, double carryingCapacity, string brand, uint numberOfStaff, 
            uint numberOfPassengers) : base(speed, carryingCapacity, brand, numberOfStaff, numberOfPassengers)
        {
        }

        public Liner(uint speed, double carryingCapacity) : base(speed, carryingCapacity)
        {
        }
    }
}