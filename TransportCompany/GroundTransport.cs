
namespace TransportCompany
{
    abstract class GroundTransport : Transport
    {
       
        protected GroundTransport(uint speed, double carryingCapacity, string brand, uint numberOfStaff,
            uint numberOfPassengers) : base(speed, carryingCapacity, brand, numberOfStaff, numberOfPassengers)
        {
        }

        protected GroundTransport(uint speed, double carryingCapacity) : base(speed, carryingCapacity)
        {
        }

       

        public override string ToString()
        {
            return GetType().Name + " GroundTransport " + base.ToString();
        }
    }
}