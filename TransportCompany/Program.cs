using System;
using System.Collections.Generic;
using TransportCompany.TransportCommon;
using TransportCompany.TransportCommon.AirTransport;
using TransportCompany.TransportCommon.GroundTransport;
using TransportCompany.TransportCommon.WaterTransport;

namespace TransportCompany
{
    /// <summary>
    ///     Пример применения созданных классов транспортных средств
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var transport = new List<Transport>(); //Список транспортных средств.

            // Создание воздушных транспортных средств
            var airplane = new Airplane(60.5, 10.0, "airplane1",
                20, 100);
            transport.Add(airplane);
            var helicopter = new Helicopter(20.0, 5.0, "helicopter1",
                1, 1);
            transport.Add(helicopter);

            // Создание наземных транспортных средств
            var car = new Car(60.0, 200.0, "car1", 0, 4);
            transport.Add(car);
            var train = new Train(55.0, 300.0, "train1", 50,
                500);
            transport.Add(train);

            // Создание водных транспортных средств
            var liner = new Liner(10.0, 20.0, "liner1", 5, 5);
            transport.Add(liner);
            var tanker = new Tanker(15.0, 200.0, "tanker1", 5,
                0);
            transport.Add(tanker);


            double bigWeight = 500;
            double middleWeight = 100;
            double littleWeight = 3;

            foreach (var curTransport in transport)
            {
                Console.WriteLine(curTransport + "\n"); // Вывод информации о транспорном средстве

                // Проверка грузоподъемности транспортных средств.
                Console.WriteLine($"{bigWeight} {curTransport.IsDeliverTheCargo(bigWeight)}");
                Console.WriteLine($"{middleWeight} {curTransport.IsDeliverTheCargo(middleWeight)}");
                Console.WriteLine($"{littleWeight} {curTransport.IsDeliverTheCargo(littleWeight)}\n");
            }
        }
    }
}