int number;
int lower, higher;
int triesCount = 5;
int userInput;
Random rand = new Random();

number = rand.Next(0,101);
lower = rand.Next(number - 10, number);
higher = rand.Next(number + 1, number + 10);

Console.WriteLine($"Загадано число от 1 до 100, оно больше чем {lower} , но меньше чем {higher}.");
Console.WriteLine($"У Вас {triesCount} попыток.");

while(triesCount-- > 0)
{
    Console.Write("Ваш ответ:   ");
    userInput = Convert.ToInt32(Console.ReadLine());
    if(userInput == number)
    {
        Console.WriteLine("Угадали!!! Это действительно число "+ number +".");
        break;
    }
    else
    {
        Console.WriteLine("Не верно! Попробуйте ещё раз!");
    }
}
if (triesCount < 0)
{
Console.WriteLine("Вы проиграли! Это было число "+ number +".");
}
