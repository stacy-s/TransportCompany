namespace TransportCompany.TransportCommon
{
    /// <summary>
    ///     Абстрактный класс транспортного средства.
    /// </summary>
    internal abstract class Transport
    {
        private double carryingCapacity; // Грузоподъемность транспортного средства.
        private double speed; // Скорость транспортного средства.

        /// <summary>
        ///     Конструктор
        /// </summary>
        /// <param name="speed">скорость</param>
        /// <param name="carryingCapacity">грузоподъемность</param>
        /// <param name="brand">марка</param>
        /// <param name="numberOfStaff">количество персонала</param>
        /// <param name="numberOfPassengers">количество пассажиров</param>
        public Transport(double speed, double carryingCapacity, string brand, uint numberOfStaff,
            uint numberOfPassengers)
        {
            Speed = speed;
            Brand = brand;
            CarryingCapacity = carryingCapacity;
            NumberOfStaff = numberOfStaff;
            NumberOfPassengers = numberOfPassengers;
        }

        /// <summary>
        ///     Конструктор
        /// </summary>
        /// <param name="speed">скорость</param>
        /// <param name="carryingCapacity">грузоподъемность</param>
        public Transport(double speed, double carryingCapacity)
        {
            Speed = speed;
            CarryingCapacity = carryingCapacity;
        }

        // Определение аксессоров класса.
        // Грузоподъемность.
        public double CarryingCapacity
        {
            get => carryingCapacity;
            protected set
            {
                if (value >= 0) carryingCapacity = value;
            }
        }

        // Скорость транспортного средства.
        public double Speed
        {
            get => speed;
            protected set
            {
                if (value >= 0) speed = value;
            }
        }

        public string Brand { get; protected set; } // Марка транспортного средства.
        public uint NumberOfStaff { get; protected set; } // Количество персонала на транспортном средстве.
        public uint NumberOfPassengers { get; protected set; } // Количество пассажиров на транспортном средстве.

        /// <summary>
        ///     Проверка возможности доставки груза с некоторой массой.
        /// </summary>
        /// <param name="cargoWeight">вес груза</param>
        /// <returns>true-груз может быть переправлен, иначе false.</returns>
        public bool IsDeliverTheCargo(double cargoWeight)
        {
            return !(CarryingCapacity < cargoWeight);
        }

        // Представление информации о транспортном средстве в виде строки.
        public override string ToString()
        {
            return
                $"\nBrand = {Brand}\nSpeed = {Speed}\n" +
                $"Carrying capacity = {CarryingCapacity}\nThe number of staff = {NumberOfStaff}\n" +
                $"The number of passengers = {NumberOfPassengers}";
        }
    }
}