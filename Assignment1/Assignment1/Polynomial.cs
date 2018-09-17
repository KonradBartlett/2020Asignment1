using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Polynomial
    {
        interface IDegree
        {
            bool Order(Object obj);
        }

        // A reference to the first node of a singly-linked list
        private Node<Term> front;

        // Creates the polynomial 0
        public Polynomial()
        {
            Term term = new Term(0, 0);
            this.AddTerm(term);
        }

        // Inserts the given term t into the current polynomial in its proper order
        public Polynomial AddTerm (Term t)
        {
            Polynomial result = null;

            return result;
        }

        // Adds the given polynomials p and q to yeild a new polynomial
        public static Polynomial operator + (Polynomial p, Polynomial q)
        {
            Polynomial result = null;

            return result;
        }

        // Multiplies the given polynomials p and q to yield a new polynomial
        public static Polynomial operator * (Polynomial p, Polynomial q)
        {
            Polynomial result = null;

            return result;
        }

        // Evaluates the current polynomial for a given x
        public double Evaluate (double x)
        {
            double result = 0;

            return result;
        }

        // Prints the current polynomial
        public void Print()
        {

        }

        public bool Order (Object obj)
        {
            bool result = false;

            return result;
        }
    }
}
