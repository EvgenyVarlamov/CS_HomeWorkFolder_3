/* Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.Write("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int index = 1;
while(index <= numberN)
{
   Console.WriteLine($"{index}^3 = {Cube(index)}");   // Console.WriteLine($"{index}^3 = {index * index * index}"); - вариант без функции
   index++;
}

/*
for(int i = 1; i <=numberN; i++)                      // Вариант с использованиемцикла for()
{
    Console.WriteLine($"{i}^3 = {Cube(i)}");
}*/

int Cube(int value)                                   // Метод/функция возвыедения в куб
{
    return Convert.ToInt32(Math.Pow((value), 3));     // reurn value = value * value * value;

}