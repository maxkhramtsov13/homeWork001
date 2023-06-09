//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
 //a = 2 b = 10 -> max = 10
 //a = -9 b = -3 -> max = -3
#region 
void NumberComparison()
{
	int firstNumber = new Random().Next(1, 100);
	Console.WriteLine(" Первое число: " + firstNumber);
	int secondNumber = new Random().Next(1, 100);
	Console.WriteLine(" Второе число: " + secondNumber);
	int maxNumber = firstNumber;
	int minNumber = firstNumber;
	
    if (secondNumber > maxNumber)
			maxNumber = secondNumber;
	if (secondNumber < maxNumber)
			minNumber = secondNumber;

		Console.WriteLine(" Максимальное число: " + maxNumber);
		Console.WriteLine(" Минимальное число: " + minNumber);
		
}
NumberComparison();
#endregion

// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22 
#region 
void ComparingThreeNumbers()
{
 Console.Write(" Введите првое число: ");
 int firstNumber = Convert.ToInt32(Console.ReadLine());
 Console.Write(" Введите второе число: ");
 int secondNumber = Convert.ToInt32(Console.ReadLine());
 Console.Write(" Введите третье число: ");
 int thirdNumber = Convert.ToInt32(Console.ReadLine());
 int maxNumber = firstNumber;

 if (secondNumber > maxNumber)
	maxNumber = secondNumber;
 if (thirdNumber > maxNumber)
	maxNumber = thirdNumber;

		Console.WriteLine(" Максимальное число: " + maxNumber);
		Console.WriteLine();
}
ComparingThreeNumbers();
#endregion

//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет 
#region 
void EvenNumber()
{
 Console.Write(" Введите првое число: ");
 int number = Convert.ToInt32(Console.ReadLine());

 if (number % 2 == 0)
		Console.WriteLine(" Четное число:" + number);
 else
		Console.WriteLine(" Не четое число: " + number);
}
EvenNumber();
#endregion

//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
#region 
void EvenNumbers()
{
 Console.Write(" Введите количество: ");
 int number = Convert.ToInt32(Console.ReadLine());
 
 for (int i = 1; i <= number; i++)
 {
  if ( i % 2 == 0)
  	Console.WriteLine(" Четные числа: " + i);
 }
}
EvenNumbers();
#endregion