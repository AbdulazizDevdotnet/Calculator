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
System.Console.Write("Please input operation (+,-,*,/,%) : ");
string operation = System.Console.ReadLine();
switch(operation)
{
    case "+":
        System.Console.WriteLine($"{firstNum} + {secondNum} = {firstNum + secondNum}");
        break;
    case "-":
        System.Console.WriteLine($"{firstNum} - {secondNum} = {firstNum - secondNum}");
        break;
    case "*":
        System.Console.WriteLine($"{firstNum} * {secondNum} = {firstNum * secondNum}");
        break;
    case "/":
        if(secondNum == 0)
        {
            System.Console.WriteLine("0 (no'l) ga bo'lish mumkin emas!!!");
        }
        else
        {
            System.Console.WriteLine($"{firstNum} / {secondNum} = {firstNum / secondNum}");
        }
        break;
    case "%":
        System.Console.WriteLine($"{firstNum} % {secondNum} = {firstNum % secondNum}");
        break;
    default:
        System.Console.WriteLine("Operation not found!!");
        break;
}
System.Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
string result = operation switch 
{
    "+" => $"{firstNum} + {secondNum} = {firstNum + secondNum}",
    "-" => $"{firstNum} - {secondNum} = {firstNum - secondNum}",
    "*" => $"{firstNum} * {secondNum} = {firstNum * secondNum}",
    "/" => secondNum == 0 ? "0 (no'l) ga bo'lish mumkin emas!!!" :$"{firstNum} / {secondNum} = {firstNum / secondNum}",
    _   => "Operation not found!!"
};
System.Console.WriteLine(result);

short counter=1;
while(counter<=100)
{
    if(counter%2==0)
    {
        System.Console.WriteLine(counter);
    }
    counter++;
}
