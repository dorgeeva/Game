
using System.Xml.Linq;
Random rnd = new Random(DateTime.Now.Millisecond);
int i = 1;
int f = 2;
while (i <= 5)
{
    if (f >= 0)
    {
        int value1 = rnd.Next(1, 100);
        int value2 = rnd.Next(1, 100);
        int summa = value1 + value2;
        Console.WriteLine($"Сложите числа {value1} и {value2}.");
        string result = Console.ReadLine();
        int resultArg = Convert.ToInt32(result);
        if (resultArg == summa)
        {
            Console.WriteLine("Результат сложения  чисел: " + resultArg.ToString());
            i += 1;
        }
        else
        {
            Console.WriteLine("Результат сложения  чисел неверен");
            f -= 1;
        }
        if (i == 6)
        {
            Console.WriteLine(" вы выиграли!");
        }
    }
    else { Console.WriteLine("Попытки закончились!, вы проиграли!"); i = 10; }
}


