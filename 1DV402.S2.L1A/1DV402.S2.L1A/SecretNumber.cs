using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L1A
{
    public class SecretNumber
    {   //Initierar variabler
        private int _count;
        private int _number;
        public const int MaxNumberOfGuesses = 7;
        //Konstruktorn som initierar metoden Initialize
        public SecretNumber()
        {
            Initialize();
        }
        //Skapar det nya hemliga talet.
        public void Initialize()
        {
            Random myRandom = new Random();
            _number = myRandom.Next(1, 101);
            _count = 0;
                      
        }
        //Skapa metod som kontrollerar gissningarna
        public bool MakeGuess(int number)
        {
            if (_count >= MaxNumberOfGuesses)
            {
                throw new ApplicationException();
            }
           
            if (number < 1 || number > 100)
            {
                throw new ArgumentOutOfRangeException();
            }

            ++_count;

            if (number == _number)
            {
                Console.WriteLine("Rätt Gissat! Du klarade det på {0} försöket.", _count);
                return true;
            }
            
            if (number > _number)
            {
                Console.WriteLine("{0} är för högt. Du har {1} gissningar kvar.", number, MaxNumberOfGuesses - _count);
            }
            else
            {
                Console.WriteLine("{0} är för lågt. Du har {1} gissningar kvar.", number, MaxNumberOfGuesses - _count);
            }
            
            if (MaxNumberOfGuesses == _count)
            {
                Console.WriteLine("Det hemliga talet är {0}.", _number);
            }
            
            return false;
        }
    }
}
