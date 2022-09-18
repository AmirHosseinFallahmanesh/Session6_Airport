using System;

namespace Part4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ISender sender = new AirPlane();
            ProductSendService service = new ProductSendService(sender);
            service.Send( "0120");

        }
    }

    interface ISender
    {
        void Send(string productCode);
    }
    class TruckSender : ISender
    {
        public void Send(string productCode)
        {
            Console.WriteLine("Send By Truck");
        }
    }

    class ShipSender : ISender
    {
        public void Send(string productCode)
        {
            Console.WriteLine("Send By Ship");
        }
    }


    class ProductSendService
    {
        ISender sender;
        public ProductSendService(ISender sender)
        {
            this.sender = sender;
        }

        public void Send( string productCode)
        {
            sender.Send(productCode);
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
