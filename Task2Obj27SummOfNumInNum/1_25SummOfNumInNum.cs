// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

//-----------------------Data input.

int number = UserInput("Enter the number: ", "Input Error!");

int UserInput(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);

        if(int.TryParse(Console.ReadLine(), out int number))
            return number;
        Console.WriteLine(errorMessage);
    }
}

//-----------------------Searching the number of digits in a number and their sum.

int SumFinding (int degreeNumber)
{
    int sum = 0;
    while (0 < degreeNumber)
    {
        sum = sum + degreeNumber % 10;
        degreeNumber = degreeNumber / 10;
    }
        return sum;
}
if (number < 0) number = - number;
int sumOfNum = SumFinding(number);
Console.WriteLine($"{number} -> {sumOfNum}");




// int NumberSize(int number)
// {
//     int numberMain = number;
//     int countNumberSize = 0;
//     do 
//     {
//         countNumberSize++;
//         number = number / 10; 
//     }
//     while (number != 0);
//         return countNumberSize;
// }
// Console.WriteLine($"{countNumberSize}");

// //-----------------------Finding the sum of digits in a number.

// int SummaryOfNumsInNum(int number, int countNumberSize)
// {
//     int numberSummary = 0;
//     int temporaryNumberSummary = 0;
//     do 
//     {
//         temporaryNumberSummary = number % 10;
//         numberSummary = numberSummary + temporaryNumberSummary; 
//         countNumberSize--;
//     }
//     while (countNumberSize > 0);
//         return (numberSummary);
// }
// Console.WriteLine($"{numberAnswer}");



// int SummaryOfNumsInNum(int number, int countNumberSize)
// {
//     int temporaryNumberSummary = 0;
//     int numberSummary = 0;
//     for(int i = 0; i <= countNumberSize; i++)
//     {  
//         temporaryNumberSummary = number % 10; 
//     }
//     return numberSummary = temporaryNumberSummary + temporaryNumberSummary;
//     Console.WriteLine($"{numberSummary}");
// }
// Console.WriteLine($"{temporaryNumberSummary}");
