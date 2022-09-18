using System;

namespace Part6.Payment
{
    public class IncomeCalculator
    {
        public double BaseSalary { get; private set; }
        public double TotalHours { get; private set; }
        public double TotalIncome { get; private set; }

        public IncomeCalculator(double baseSalary, double totalHours)
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
            return (obj as IncomeCalculator).TotalIncome == this.TotalIncome;
        }

        public override string ToString()
        {
            return $"the income is {TotalIncome}";
        }

        public static double operator /(IncomeCalculator current, double coi)
        {
            return current.TotalIncome * ((100 - coi) / 100);
        }

        public static double operator +(IncomeCalculator current, IncomeCalculator offset)
        {
            return current.TotalIncome + offset.TotalIncome;
        }

        public static double operator -(IncomeCalculator current, IncomeCalculator offset)
        {
            return current.TotalIncome - offset.TotalIncome;
        }

    }
}
