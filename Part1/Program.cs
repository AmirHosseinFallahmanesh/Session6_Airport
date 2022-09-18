using System;
//solid
//o-> open close principle
namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseMessage message = new DangerMessage();
       
            message.Show("something");

        
        }
    }

    class BaseMessage
    {
       public virtual void Show(string message)
        {
            Console.WriteLine($"message : {message} - {DateTime.Now}");
        }
    }

    class WarningMessage:BaseMessage
    {
        public override void Show(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Info : {message} - {DateTime.Now}");
        }
    }
    class DangerMessage : BaseMessage
    {
        public override void Show(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Info : {message} - {DateTime.Now}");
        }
    }

}
