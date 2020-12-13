using System;

namespace NumeralExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console . Clear ();
            Console . WriteLine ( " --- Extenso Numeral " );
            Console . Write ( " Digite qualquer número: " );
            int  numeroDigitado  =  Convert . ToInt32 ( Console . ReadLine ());
            string  numeroExtenso  =  numeroDigitado . ToString ();
            Console . WriteLine (" Número por extenso: { numeroExtenso } ");
        }
    }
}