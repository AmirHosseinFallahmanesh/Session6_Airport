using System;

namespace Part3
{
    //INTERFACE
    class Program
    {
        static void Main(string[] args)
        {
            //TAEmailSender tA = new TAEmailSender();
            //tA.Send("", "", "");
            //Console.WriteLine();
            //TBEmailSender tB = new TBEmailSender();
            //tB.Send("", "", "");
            //Console.WriteLine();
            ISender sender = new TBEmailSender();
            sender.Send("", "", "");
           
        }
    }
    class TAEmailSender : ISender
    {
        public int Port { get; set; }

        public string Source => throw new NotImplementedException();

        public void Send(string destination, string title, string body)
        {
            Console.WriteLine("*******************");
            Console.WriteLine("Send By TA");
        }
    }

    class TBEmailSender : ISender
    {
        public int Port { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Source { get; }

        public void Send(string destination, string title, string body)
        {
            Console.WriteLine("*******************");
            Console.WriteLine("*******************");
            Console.WriteLine("Send By TB");
            Console.WriteLine("*******************");
            Console.WriteLine("*******************");
        }
    }
}
