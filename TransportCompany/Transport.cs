using System;

namespace TransportCompany
{
    abstract class Transport
    {
        private double carryingCapacity;

        public double CarryingCapacity
        {
            get => carryingCapacity;
            protected set
            {
                if (value >= 0)
                {
                    carryingCapacity = value;
                }
            }
        }

        public uint Speed { get; protected set; }
        public string Brand { get; protected set; }
        public uint NumberOfStaff { get; protected set; }
        public uint NumberOfPassengers { get; protected set; }
        
        public Transport(uint speed, double carryingCapacity, string brand, uint numberOfStaff, uint numberOfPassengers)
        {
            Speed = speed;
            Brand = brand;
            CarryingCapacity = carryingCapacity;
            NumberOfStaff = numberOfStaff;
            NumberOfPassengers = numberOfPassengers;
        }
        public Transport(uint speed, double carryingCapacity)
        {
            Speed = speed;
            CarryingCapacity = carryingCapacity;
        }
        public bool IsDeliverTheCargo(double cargoWeight)
        {
            return !(CarryingCapacity < cargoWeight);
        }
        public override string ToString()
        {
            return
                $"\nBrand = {Brand}\nSpeed = {Speed}\n" +
                $"Carrying capacity = {CarryingCapacity}\nThe number of staff = {NumberOfStaff}\n" +
                $"The number of passengers = {NumberOfPassengers}";
        }
    }
}