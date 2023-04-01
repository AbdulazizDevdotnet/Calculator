int firstNum,secondNum;
System.Console.Write("Please input first number: ");
firstNum = System.Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Please input second number: ");
secondNum = System.Convert.ToInt32(System.Console.ReadLine());
if(firstNum > secondNum)
{
    System.Console.WriteLine($"First number bigger than second number {firstNum} > {secondNum}");
}
else if(firstNum == secondNum)
{
    System.Console.WriteLine($"First and second numbers equal {firstNum} = {secondNum}");
}
else
{
    System.Console.WriteLine($"First number smaller than second number {firstNum} < {secondNum}");
}