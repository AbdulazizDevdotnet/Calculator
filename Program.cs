using System;
using CALCULATOR.Classes;
namespace CALCULATOR
{
    class Program
    {
        static void Main()
        {
            Security security = new Security();
            Calculatr calculatr = new Calculatr();
            security.CheckPassword();
            calculatr.Greetings();
            calculatr.GetInputs();
            calculatr.CompareNumbers();
            string calculateresult = calculatr.CalculateFirstMethod();
            Console.WriteLine(calculateresult);
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
            string calculateresult2 = calculatr.CalculateSecondMethod();
            Console.WriteLine(calculateresult2);
            calculatr.PrintEvenNumbers();
            calculatr.PrintMultiplicationTable();
        }
    }
}
