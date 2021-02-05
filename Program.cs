using System;

namespace DateModifierProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();
       
            Console.WriteLine(Math.Abs(DateModifier.GetDiffBetweenDatesInDays(firstDate, secondDate)));
            
        }

       


    }
}
