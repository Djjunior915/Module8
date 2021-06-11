using System;

namespace Module8
{
    class Program
    {
        static void Main(string[] args)
        {
            Demographics<string> Panchita1 = new Demographics<string>();
            Panchita1.misc = "Rock this town";
            Panchita1.age = 26;

            Console.WriteLine(Panchita1.misc);
            Console.WriteLine(Panchita1.age);

        }
    }

    

    class Demographics<T>
    {
        public T misc { get; set; }
        public int age { get; set; }
    }
}
