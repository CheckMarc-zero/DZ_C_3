int a = insertNumber("Введите пятизначное число:");

if (okNumber(a)) Console.WriteLine("Неверно введено число.");
else 
{
    if (palindromOk(a)) Console.WriteLine("Введённое число - палиндром.");
    else Console.WriteLine("Введённое число - не палиндром.");
}

int insertNumber(string massege)
{
Console.WriteLine(massege);
int number = int.Parse(Console.ReadLine());
return number;
}

bool okNumber(int n)
{
    if (n/100000 != 0 || n/10000 == 0) return true;
    else return false;
}

bool palindromOk (int n)
{
    if (n/10000 == n%10 && (n/1000)%10 == (n%100)/10) return true;
    else return false;
}
