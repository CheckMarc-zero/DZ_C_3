int [] A = vvodArray("Введите координаты точки А:");

int [] B = vvodArray("Введите координаты точки В:");

double sum = 0;

for (int i = 0; i<=2; i++)
{
    sum = sum + ((B[i]-A[i])*(B[i]-A[i]));
}

double dlinnaAB = Math.Sqrt(sum);

Console.Write("Расстояние между А и В равно ");
Console.WriteLine(dlinnaAB);


int insertNumber(string massege)
{
Console.WriteLine(massege);
int number = int.Parse(Console.ReadLine());
return number;
}

int [] vvodArray (string massege)
{
    Console.WriteLine(massege);
    int [] N = new int[3];
    N[0] = insertNumber("Введите х:");
     N[1] = insertNumber("Введите y:");
      N[2] = insertNumber("Введите z:");
      return N;
}

