using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Polynomials
    {
        private List<Polynomial> P;

        // Creates an empty list of polynomials
        public Polynomials()
        {
            Polynomials P = null;
        }

        // Retrieves the polynomial stored at position i-1 in the list
        public Polynomial Retrieve (int i)
        {
            Polynomial result = null;
            
            result = P.ElementAt(i);

            return result;
        }

        // Inserts polynomial p into the list of polynomials
        public void Insert (Polynomial p)
        {
            P.Add(p);
        }

        // Deletes the polynomials at index i-1
        public void Delete (int i)
        {
            P.RemoveAt(i-1);
        }

        // Prints out the list of polynomials (beginning with polynomial 1)
        public void Print()
        {
            if (P != null)
            {
                // for every polynomial in p
                for (int i = 0; i < P.Count; i++)
                {
                    // write polynomial at index i
                    Console.WriteLine(P.ElementAt(i));
                }
            }
        }
    }
}
