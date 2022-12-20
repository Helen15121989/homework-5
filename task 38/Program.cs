//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76


Console.WriteLine("Введите размерность массива: ");

int size = int.Parse(Console.ReadLine());

int[] number = new int[size];

GetRandomNumber(number);
Console.WriteLine("Наш массив: ");

PrintArray(number);

int min = 0;
int max = 0;

for (int i = 0; i < number.Length; i++)

{
if  (number[i] > max)
    
    {
        max = number [i];
    }
    
if (number [i] < min)
    
    {
        min = number [i];
    }

}


Console.WriteLine("Максимальное значение:" + max);
Console.WriteLine("Минимальное значение:" + min);
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void GetRandomNumber(int[] number)
{
    for (int i = 0; i < number.Length; i++)
    {
        number[i] = new Random().Next(10, 100);
    }
}
void PrintArray(int[] number)
{

    for (int i = 0; i < number.Length; i++)
    {
        Console.Write(number[i] + " ");
    }

    Console.WriteLine();
}


