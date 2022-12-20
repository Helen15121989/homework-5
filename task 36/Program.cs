//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


Console.WriteLine ("Введите размерность массива: ");

int size = int.Parse(Console.ReadLine());

int [] number = new int [size];

GetRandomNumber (number);
Console.WriteLine("Наш массив: ");

PrintArray(number);

int result = 0;

for (int i = 1; i < number.Length; i++)

if (i %2 !=0)
{
    result = result + number [i];
}

Console.WriteLine("Сумма элементов равна: "  + result);


void GetRandomNumber(int[] number)
{
    for(int i = 0; i < number.Length; i++)
    {
        number[i] = new Random().Next(10,100);
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
