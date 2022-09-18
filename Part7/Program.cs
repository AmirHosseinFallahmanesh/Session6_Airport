using Part7Dll;
using System;

namespace Part7
{
    class Program
    {
        static void Main(string[] args)
        {
            Father father = new Father();
            OtherChild otherChild = new OtherChild();
            


        }
    }
    class Father
    {
        private int a;
        protected int b;
    }

    class Child : Father
    {
        public Child()
        {
            b = 10;
           // a = 10;
        }
    }


    class OtherChild :OtherFather
        {
        public OtherChild()
        {
            k = 10;
        }
    }
}
