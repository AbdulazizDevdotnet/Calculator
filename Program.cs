int kaschaAge = 5;
int yourAge;
string yourName;

System.Console.Write("Please input your name: ");
yourName = System.Console.ReadLine();
System.Console.Write("Please input your age: ");
yourAge = System.Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine($"{yourName} sening yoshing va Keschaning yoshi orasidagi farq {yourAge-kaschaAge} yilga teng");
