namespace TransportCompany.TransportCommon.WaterTransport
{
    /// <summary>
    ///     Класс водного транспортного средства
    /// </summary>
    internal abstract class WaterTransport : Transport
    {
        /// <summary>
        ///     Конструктор
        /// </summary>
        /// <param name="speed">скорость</param>
        /// <param name="carryingCapacity">грузоподъемность</param>
        /// <param name="brand">марка</param>
        /// <param name="numberOfStaff">количество персонала</param>
        /// <param name="numberOfPassengers">количество пассажиров</param>
        protected WaterTransport(double speed, double carryingCapacity, string brand, uint numberOfStaff,
            uint numberOfPassengers) : base(speed, carryingCapacity, brand, numberOfStaff, numberOfPassengers)
        {
        }

        /// <summary>
        ///     Конструктор
        /// </summary>
        /// <param name="speed">скорость</param>
        /// <param name="carryingCapacity">грузоподъемность</param>
        protected WaterTransport(double speed, double carryingCapacity) : base(speed, carryingCapacity)
        {
        }

        // Представление информации о транспортном средстве в виде строки.
        public override string ToString()
        {
            return GetType().Name + " WaterTransport " + base.ToString();
        }
    }
}