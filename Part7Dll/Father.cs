using System;

namespace Part7Dll
{
    public class Father
    {
        private int a;
        internal int b;
    }

    public class Child:Father
    {
        public Child()
        {
            b = 165;
        }

    }

     public class OtherFather
    {
        protected int k;
    }
    
}
