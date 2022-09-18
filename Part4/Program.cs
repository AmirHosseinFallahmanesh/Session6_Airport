using System;

namespace Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductSendService service = new ProductSendService();
            service.Send(8, "0120");

        }
    }

    /// <summary>
    /// for send product with truck
    /// </summary>
    class TruckSender
    {
        public void SendByTruck(string productCode)
        {
            Console.WriteLine("Send By Truck");
        }
    }
    /// <summary>
    /// for send product with ship
    /// </summary>
    class ShipSender
    {
       public void SendByShip(string productCode)
        {
            Console.WriteLine("Send By Ship");
        }
    }


    class ProductSendService
    {
        ShipSender shipSender;
        TruckSender truckSender;
        Airplane airplane;
        public ProductSendService()
        {
            shipSender = new ShipSender();
            truckSender = new TruckSender();
            airplane = new Airplane();
        }
        public void Send(int month,string productCode)
        {
            if (month>6)
            {
                shipSender.SendByShip(productCode);
            }
            else
            {
                airplane.SendByAirplan(productCode);
            }
        }

    }

    class Airplane
    {

        public void SendByAirplan(string productCode)
        {
            Console.WriteLine("Send By airplane");
        }
    }
}
