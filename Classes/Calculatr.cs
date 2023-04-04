using System;
namespace CALCULATOR.Classes
{
    public class Calculatr
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public string Operation { get; set; }
        public void GetInputs()
        {
            Console.Write("Please input first number: ");
            FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please input second number: ");
            SecondNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please input operation (+,-,*,/,%) : ");
            Operation = Console.ReadLine();
        }
        public void CompareNumbers()
        {
            if(FirstNumber > SecondNumber)
            {
                Console.WriteLine($"First number bigger than second number {FirstNumber} > {SecondNumber}");
            }
            else if(FirstNumber == SecondNumber)
            {
                Console.WriteLine($"First and second numbers equal {FirstNumber} = {SecondNumber}");
            }
            else
            {
                Console.WriteLine($"First number smaller than second number {FirstNumber} < {SecondNumber}");
            }
        }
        
        public void Greetings()
        {
             Console.WriteLine("\tHey Welcome");
        }
        public string CalculateFirstMethod()
        {
            switch(Operation)
            {
                case "+":
                    return $"{FirstNumber} + {SecondNumber} = {FirstNumber + SecondNumber}";
                case "-":
                    return $"{FirstNumber} - {SecondNumber} = {FirstNumber - SecondNumber}";
                case "*":
                    return $"{FirstNumber} * {SecondNumber} = {FirstNumber * SecondNumber}";
                case "/":
                    if(SecondNumber == 0)
                    {
                        return ("0 (no'l) ga bo'lish mumkin emas!!!");
                    }
                    else
                    {
                        return ($"{FirstNumber} / {SecondNumber} = {FirstNumber / SecondNumber}");
                    }
                case "%":
                    return ($"{FirstNumber} % {SecondNumber} = {FirstNumber % SecondNumber}");
                default:
                    return ("Operation not found!!");
            }
        }
        public string CalculateSecondMethod()
        {
            return Operation switch 
            {
                "+" => $"{FirstNumber} + {SecondNumber} = {FirstNumber + SecondNumber}",
                "-" => $"{FirstNumber} - {SecondNumber} = {FirstNumber - SecondNumber}",
                "*" => $"{FirstNumber} * {SecondNumber} = {FirstNumber * SecondNumber}",
                "/" => SecondNumber == 0 ? "0 (no'l) ga bo'lish mumkin emas!!!" :$"{FirstNumber} / {SecondNumber} = {FirstNumber / SecondNumber}",
                _   => "Operation not found!!"
            };
        }
        public void PrintEvenNumbers()
        {
            short counter=1;
            while(counter<=100)
            {                       
                if(counter%2==0)
                {
                    Console.WriteLine(counter);
                }
                counter++;
            }
        }
        public void PrintMultiplicationTable()
        {
            for(int iteration = 1;iteration < 11; iteration++)
            {
                for(int inIteration = 1;inIteration < 11;inIteration++)
                {
                    Console.WriteLine($"{iteration} x {inIteration} = {iteration * inIteration}");
                }
                Console.WriteLine();
            }
            
        }
    }
}