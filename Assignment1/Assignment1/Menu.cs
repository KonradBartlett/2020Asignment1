using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Menu
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Polynomials polynomials = new Polynomials();
                polynomials.Print();

                Console.Write("\n\n1) Create a polynomial\n2) Add two polynomials\n3) Multiply two polynomials\n4) Delete a polynomial\n5) Evaluate a polynomial\n\nSelect an option: ");
                String option = Console.ReadLine();
                int i = Convert.ToInt32(option);

                int first = 0, second = 0;
                Polynomial p = new Polynomial();
                Polynomial q = new Polynomial();
                Polynomial r = new Polynomial();
                p = null;
                q = null;
                r = null;

                switch (i)
                {
                    case 1:
                        Console.Write("1: Enter a coefficient ");
                        double coefficient = Convert.ToDouble(Console.ReadLine());
                        Console.Write("   Enter an exponent ");
                        byte exponent = Convert.ToByte(Console.ReadLine());
                        break;

                    case 2:
                        Console.Write("2: Enter the index of the first polynomial ");
                        first = Convert.ToInt32(Console.ReadLine());
                        p = polynomials.Retrieve(first);

                        Console.Write("   Enter the index of the second polynomial ");
                        second = Convert.ToInt32(Console.ReadLine());
                        q = polynomials.Retrieve(second);

                        r = p + q;
                        r.Print();
                        break;

                    case 3:
                        Console.Write("3: Enter the index of the first polynomial ");
                        first = Convert.ToInt32(Console.ReadLine());
                        p = polynomials.Retrieve(first);

                        Console.Write("   Enter the index of the second polynomial ");
                        second = Convert.ToInt32(Console.ReadLine());
                        q = polynomials.Retrieve(second);

                        r = p + q;
                        r.Print();
                        break;

                    case 4:
                        Console.Write("4: Enter the index of polynomial you would like to delete ");
                        first = Convert.ToInt32(Console.ReadLine());
                        polynomials.Delete(first);
                        break;

                    case 5:
                        Console.Write("5: Enter the index of the polynomial you would like to evaluate ");
                        p = polynomials.Retrieve(first);
                        int x = 0;
                        Console.Write("   Enter the x value for the polynomial to be evaluated ");
                        x = Convert.ToInt32(Console.ReadLine());
                        p.Evaluate(x);
                        break;

                    default:
                        Console.WriteLine("Error, try entering a value from 1 - 5");
                        break;
                }
            }
        }
    }
}
