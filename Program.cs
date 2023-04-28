// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] Massive =new int[10];

// int hetNum=0;

// for(int i=0; i<Massive.Length; i++)

// {
// Massive [i] =new Random().Next(100,1000);

// if (Massive[i]%2==0)

//             {
//             hetNum=hetNum+1;
//             }

// }
// Console.WriteLine(String.Join(",",Massive));
// Console.WriteLine(hetNum);


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] Massive =new int[4];

// int NehetNum=0;

// for(int i=0; i<Massive.Length; i++)

// {
// Massive [i] =new Random().Next(-99,100);

// if (Massive[i]%2 !=0)

//             {
//             NehetNum+=Massive[i]; //NehetNum=NehetNum+Massive[i]
//             }

// }
// Console.WriteLine(String.Join(",",Massive));
// Console.WriteLine(NehetNum);



// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] Massive =new double[5];

for(int i=0; i<Massive.Length; i++)
{
Massive [i] = Math.Round (new Random().NextDouble()*100,2);
}

double maxNum=Massive [0];
double minNum=Massive [0];
for(int i=0; i<Massive.Length; i++)
{

    if (Massive[i] > maxNum )
        {
            maxNum = Massive[i];
        }

    if (Massive[i] < minNum )

        {
        minNum = Massive[i];
        }

}
double raz = Math.Round ((maxNum-minNum),2);

Console.WriteLine($"Сгенерированный массив: {String.Join(" | ",Massive )}");

Console.WriteLine($"Максимальное значение массива: {maxNum}");
Console.WriteLine($"Минимальное значение массива: {minNum}");

Console.WriteLine($"Разница между максимальным и минимальным значением массива: {raz} ");