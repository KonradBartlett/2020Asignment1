﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Term
    {
        private double coefficient;
        private byte exponent;
        
        // Creates a term with the given coefficient and exponent
        public Term (double coefficient, byte exponent)
        {
            this.coefficient = coefficient;
            this.exponent = exponent;
        }

        // Evaluates the current term for a given x
        public double Evaluate (double x)
        {
            double result = 0;

            // for value of exponent, multiply coefficient by itself
            for(int i = 0; i < exponent; i++)
            {
                result = coefficient * coefficient;
            }

            return result;
        }

        // Returns -1, 0, or 1 if the exponent of the current therm
        // is less than, equal to, or grather than the exponent of obj.
        public int CompareTo (Object obj)
        {
            int result = 0;
            Term term = obj as Term;

            if (term.Exponent < this.exponent)
            {
                result = -1;
            }

            if (term.Exponent == this.exponent)
            {
                result = 0;
            }

            if (term.Exponent > this.exponent)
            {
                result = 1;
            }

            return result;
        }

        // Read and write properties for each data member
        public double Coefficient
        {
            get { return this.coefficient; }
            set { this.coefficient = value; }
        }

        public byte Exponent
        {
            get { return this.exponent; }
            set { this.exponent = value; }
        }
    }
}
