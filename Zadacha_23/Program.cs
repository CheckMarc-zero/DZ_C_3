int N = insertNumber("Введите число N:");

int insertNumber(string massege)
{
Console.WriteLine(massege);
int number = int.Parse(Console.ReadLine());
return number;
}

if (N > 1)
{
Console.WriteLine("Табица кубов от 1 до N:");

for (int i = 1; i<= N; i++)
{
    int cube = i*i*i;
    Console.Write(cube);
    if (i != N) Console.Write(",");
}
}
else
{
   Console.WriteLine("Табица кубов от N до 1:");

for (int i = N; i<= 1; i++)
{
    int cube = i*i*i;
    Console.Write(cube);
    if (i != 1) Console.Write(", ");
} 
}