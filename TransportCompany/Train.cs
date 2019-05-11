namespace TransportCompany
{
    class Train : GroundTransport
    {
        public Train(uint speed, double carryingCapacity, string brand, uint numberOfStaff, 
            uint numberOfPassengers) : base(speed, carryingCapacity, brand, numberOfStaff, numberOfPassengers)
        {
        }

        public Train(uint speed, double carryingCapacity) : base(speed, carryingCapacity)
        {
        }
    }
}