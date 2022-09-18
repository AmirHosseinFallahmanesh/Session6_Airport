using System;

namespace Part2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //MyClass my = new MyClass();
            //Console.WriteLine("GetType " + my.GetType());
            //Console.WriteLine("ToString " + my.ToString());
            //Console.WriteLine("GetHashCode " + my.GetHashCode());

            Income income1 = new Income(200, 100);
            Console.WriteLine(income1.ToString());
            Income income2 = new Income(200, 400);
            Console.WriteLine(income2); //call to string

            Console.WriteLine(income1.Equals(income2)?"eq":"neq");

            Console.WriteLine(income1/10);

            Console.WriteLine(income1+income2);
            Console.WriteLine(income1-income2);
            
        }
    }

     class Income
    {
        public double BaseSalary { get; private set; }
        public double TotalHours { get; private set; }
        public double TotalIncome { get; private set; }

        public Income(double baseSalary, double totalHours)
        {
            updateIncome(baseSalary, totalHours);
            calculateIncome();

        }

        private void updateIncome(double baseSalary, double totalHours)
        {
            BaseSalary = baseSalary;
            TotalHours = totalHours;
        }

        private void calculateIncome()
        {

            TotalIncome = BaseSalary * TotalHours;

        }
        //shallow copy ->true
        public override bool Equals(object obj)
        {
            return (obj as Income).TotalIncome == this.TotalIncome;
        }

        public override string ToString()
        {
            return $"the income is {TotalIncome}";
        }

         public static double operator/( Income current,double coi)
        {
            return current.TotalIncome * ((100-coi) / 100);
        }

        public static double operator +(Income current, Income offset)
        {
            return current.TotalIncome + offset.TotalIncome;
        }

        public static double operator -(Income current, Income offset)
        {
            return current.TotalIncome - offset.TotalIncome;
        }

    }

    internal class MyClass : Object
    {
        public override string ToString()
        {
            return "It converts an object to its string representation" +
                " so that it is suitable for display.";
        }

    }
}
