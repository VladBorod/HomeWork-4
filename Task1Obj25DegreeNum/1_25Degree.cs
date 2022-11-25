// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵) 
// 2, 4 -> 16

Console.Clear();

//-----------------------Data input.

int number = UserInput("Enter the number: ", "Input Error!");
int exponentNumber = UserInput("Enter degree of the number: ", "Input Error!");
int numberAnswer = Exponentiation(number, exponentNumber);

int UserInput(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);

        if(int.TryParse(Console.ReadLine(), out int number))
            return number;
         
        if(int.TryParse(Console.ReadLine(), out int exponentNumber))
            return exponentNumber;
        Console.WriteLine(errorMessage);
    }
}

//-----------------------Number exponentiation.

int Exponentiation(int num1, int num2)
{
    int numberDegree = 1;
    for(int i = 1; i <= num2; i++)
    {
    numberDegree = numberDegree * num1;
    }
        return numberDegree;
}
if (0 < exponentNumber)
{
    Console.WriteLine($"{number}, {exponentNumber} -> {numberAnswer}");
}
else 
    Console.WriteLine($"Введите натуральное число!");
