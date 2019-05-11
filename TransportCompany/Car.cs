namespace TransportCompany
{
    class Car : GroundTransport
    {
        
        public Car(uint speed, double carryingCapacity, string brand, uint numberOfStaff,
            uint numberOfPassengers) : base(speed, carryingCapacity, brand, numberOfStaff, numberOfPassengers)
        {
        }

        public Car(uint speed, double carryingCapacity) : base(speed, carryingCapacity)
        {
        }
        
    }
}