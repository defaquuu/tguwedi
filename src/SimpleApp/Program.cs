using System;

class Program
{
    static void Main()
    {
        var calculator = new Calculator();

        Console.WriteLine("Простой калькулятор для уведомлений");
        Console.WriteLine("========================================");

        Console.WriteLine($"5 + 3 = {calculator.Add(5, 3)}");
        Console.WriteLine($"10 - 4 = {calculator.Subtract(10, 4)}");
        Console.WriteLine($"6 * 7 = {calculator.Multiply(6, 7)}");
        Console.WriteLine($"15 / 3 = {calculator.Divide(15, 3)}");

        Console.WriteLine($"Число 4 четное: {calculator.IsEven(4)}");
        Console.WriteLine($"Число 17 простое: {calculator.IsPrime(17)}");
    }
}