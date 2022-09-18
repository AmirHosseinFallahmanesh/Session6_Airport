using System;

namespace Part4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductSendService service = new ProductSendService();
            service.Send(8, "0120");

        }
    }

    interface ISender
    {
        void Send(string productCode);
    }
    class TruckSender:ISender
    {
        public void Send(string productCode)
        {
            Console.WriteLine("Send By Truck");
        }
    }

    class ShipSender:ISender
    {
        public void Send(string productCode)
        {
            Console.WriteLine("Send By Ship");
        }
    }


    class ProductSendService
    {
        ISender sender;

        public void Send(int month, string productCode)
        {
            if (month > 6)
            {
                sender = new ShipSender();
                sender.Send(productCode);
            }
            else
            {
                sender = new AirPlane();
                sender.Send(productCode);
            }
        }
    }

    class AirPlane : ISender
    {
        public void Send(string productCode)
        {
            Console.WriteLine("Send By Airplane");
        }
    }
}
