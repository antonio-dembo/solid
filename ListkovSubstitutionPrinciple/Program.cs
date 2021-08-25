using System;

namespace ListkovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            // We cannot simply substitute a Triangle, which results in printing
            // shape of a triangle, with Circle.
            Triangle triangle = new Circle();
            Console.WriteLine(triangle.GetShape());
        }
    }
}
