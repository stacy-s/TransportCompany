namespace TransportCompany.TransportCommon.AirTransport
{
    /// <summary>
    ///     Класс вертолет
    /// </summary>
    internal class Helicopter : AirTransport
    {
        /// <summary>
        ///     Конструктор
        /// </summary>
        /// <param name="speed">скорость</param>
        /// <param name="carryingCapacity">грузоподъемность</param>
        /// <param name="brand">марка</param>
        /// <param name="numberOfStaff">количество персонала</param>
        /// <param name="numberOfPassengers">количество пассажиров</param>
        public Helicopter(double speed, double carryingCapacity, string brand, uint numberOfStaff,
            uint numberOfPassengers) : base(speed, carryingCapacity, brand, numberOfStaff, numberOfPassengers)
        {
        }

        /// <summary>
        ///     Конструктор
        /// </summary>
        /// <param name="speed">скорость</param>
        /// <param name="carryingCapacity">грузоподъемность</param>
        public Helicopter(double speed, double carryingCapacity) : base(speed, carryingCapacity)
        {
        }
    }
}