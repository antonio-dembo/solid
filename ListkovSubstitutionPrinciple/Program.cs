using System;

namespace ListkovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Circle();
            Console.WriteLine(shape.GetShape());

            shape = new Triangle();
            Console.WriteLine(shape.GetShape());
        }
    }
}
