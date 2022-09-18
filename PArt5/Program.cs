using System;

namespace Part5
{
    class Program
    {
        static void Main(string[] args)
        {
           // Person person = new Person(); 
        }
    }

    
   abstract class Person
    {   
        public string Id { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public abstract string GetInformation();
        public abstract string GetDemo();
    }

    class Employee : Person
    {
        public string ManagerName { get; set; }

        public override string GetDemo()
        {
            throw new NotImplementedException();
        }

        public override string GetInformation()
        {
            return ManagerName + " " + Name + " " + Surname;
        }
    }
    class Manager : Person
    {
        public string Segment { get; set; }

        public override string GetDemo()
        {
            throw new NotImplementedException();
        }

        public override string GetInformation()
        {
            return Segment + " " + Name + " " + Surname;
        }
    }

}
