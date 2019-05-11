namespace TransportCompany
{
    class Airplane : AirTransport
    {
        public Airplane(uint speed, double carryingCapacity, string brand, uint numberOfStaff, 
            uint numberOfPassengers) : base(speed, carryingCapacity, brand, numberOfStaff, numberOfPassengers)
        {
        }

        public Airplane(uint speed, double carryingCapacity) : base(speed, carryingCapacity)
        {
        }
    }
}