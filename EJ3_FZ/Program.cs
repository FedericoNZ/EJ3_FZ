
int[] valor = new int[10];

Console.WriteLine($"Bienvenido, ingrese {valor.Length} números.\n");

for (int i = 0; i < valor.Length; i++)
{
    Console.WriteLine($"Valor del número {i + 1}:");
    valor[i] = int.Parse(Console.ReadLine());
}

int suma = 0;

for (int i = 0; i < valor.Length; i++) 
{
    suma += valor[i]; 
}

int max = Int32.MinValue;

for (int i = 0; i < valor.Length; i++)
{
    if (valor[i] > max)
        max = valor[i];
}

int min = Int32.MaxValue;

for (int i = 0; i < valor.Length; i++)
{
    if (valor[i] < min)
        min = valor[i];
}

int promedio = 0;

for (int i = 0; i < valor.Length; i++)
{
    promedio = suma / valor.Length;
}

Console.WriteLine("\n\nLos valores ingresados son:");

for (int i = 0; i < valor.Length; i++)
{
    Console.WriteLine($"{i + 1}: {valor[i]}");
}

Console.WriteLine($"\nLos valores sumados dan como resultado: {suma}");
Console.WriteLine($"El valor máximo es: {max}");
Console.WriteLine($"El valor mínimo es: {min}");
Console.WriteLine($"El promedio de tus números es: {promedio}");
Console.ReadKey();
