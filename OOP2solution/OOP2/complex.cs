using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace routOOP2
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }
        //public Complex(int _real, int _imag)
        //{
        //    Real = _real;
        //    Imag = _imag;
        //}

        #region operator_overloading
        //must  be static member function
        public static Complex operator +(Complex Left, Complex Right)
        {
            return new Complex()
            {
                Real = (Left?.Real ?? 0) + (Right?.Real ?? 0),
                Imag = (Left?.Imag ?? 0) + (Right?.Imag ?? 0),
                /// left != null ? left.Real : null 
            };
        }

        public static Complex operator ++(Complex c)
        {
            return new Complex()
            {
                Real = (c?.Real ?? 0) + 1,
                Imag = (c?.Imag ?? 0),
            };
        }

        public static bool operator >(Complex Left, Complex Right)
        {
            if (Left.Real == Right.Real)
                return Left.Imag < Right.Imag;
            else
                return Left.Real > Right.Real;
        }
        public static bool operator <(Complex Left, Complex Right)
        {
            if (Left.Real == Right.Real)
                return Left.Imag < Right.Imag;
            else
                return Left.Real < Right.Real;
        }

        public static explicit operator string(Complex c)
        {
            return c?.ToString() ?? "";
        }

        public static implicit operator int(Complex C)
        {
            return C?.Real ?? 0;
        }

        #endregion
        public override string ToString()
        {
            return $"{Real}  +  {Imag}i";
        }
    }
}
