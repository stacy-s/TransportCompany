namespace TransportCompany.TransportCommon.WaterTransport
{
    /// <summary>
    ///     Класс лайнер
    /// </summary>
    internal class Liner : WaterTransport
    {
        /// <summary>
        ///     Конструктор
        /// </summary>
        /// <param name="speed">скорость</param>
        /// <param name="carryingCapacity">грузоподъемность</param>
        /// <param name="brand">марка</param>
        /// <param name="numberOfStaff">количество персонала</param>
        /// <param name="numberOfPassengers">количество пассажиров</param>
        public Liner(double speed, double carryingCapacity, string brand, uint numberOfStaff,
            uint numberOfPassengers) : base(speed, carryingCapacity, brand, numberOfStaff, numberOfPassengers)
        {
        }

        /// <summary>
        ///     Конструктор
        /// </summary>
        /// <param name="speed">скорость</param>
        /// <param name="carryingCapacity">грузоподъемность</param>
        public Liner(double speed, double carryingCapacity) : base(speed, carryingCapacity)
        {
        }
    }
}