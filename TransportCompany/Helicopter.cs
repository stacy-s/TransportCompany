namespace TransportCompany
{
    class Helicopter : AirTransport
    {
        public Helicopter(uint speed, double carryingCapacity, string brand, uint numberOfStaff, 
            uint numberOfPassengers) : base(speed, carryingCapacity, brand, numberOfStaff, numberOfPassengers)
        {
        }

        public Helicopter(uint speed, double carryingCapacity) : base(speed, carryingCapacity)
        {
        }
    }
}