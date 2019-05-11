using System;

namespace TransportCompany
{
    public class Transport
    {
        private uint speed;
        private double carryingCapacity;
        private string brand;
        private uint numberOfStaff;
        private uint numberOfPassengers;

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
        
        public Transport(){}


        public bool IsDeliverTheCargo(double cargoWeight)
        {
            return !(carryingCapacity < cargoWeight);
        }

        public override string ToString()
        {
            return
                $"Марка = {Brand}\nСкорость = {Speed}\n" +
                $"Грузоподъемность = {CarryingCapacity}\nКоличество персонала = {NumberOfStaff}\n" +
                $"Количество пассажиров = {NumberOfPassengers}";
        }
    }
}