 //Задайте массив заполненный случайными положительными трёхзначными числами. 
 //Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


Console.WriteLine ("Введите размерность массива: ");

int size = int.Parse(Console.ReadLine());

int [] number = new int [size];

GetRandomNumber (number);
Console.WriteLine("Наш массив: ");
PrintArray(number);

int count = 0;

for (int i = 0; i < number.Length; i++)
if (number[i] % 2 == 0)
count++;

Console.WriteLine("Четных чисел: " + count);

void GetRandomNumber(int[] number)
{
    for(int i = 0; i < number.Length; i++)
    {
        number[i] = new Random().Next(99,1000);
    }
}
void PrintArray(int[] number)
{
    
    for(int i = 0; i < number.Length; i++)
    {
        Console.Write(number[i] + " ");
    }
    
    Console.WriteLine();
}
