﻿public class Program
{
    public static void Main(string[] args)
    {
        // Przykładowa tablica liczb całkowitych
        int[] numbers = { 10, 20, 30, 40, 50 };

        Console.WriteLine(123);
        
        // Wywołanie metody Average i wyświetlenie wyniku
        double average = CalculateAverage(numbers);
        Console.WriteLine("Średnia liczb: " + average);
    }

    // Metoda do obliczania średniej z tablicy liczb całkowitych
    public static double CalculateAverage(int[] numbers)
    {
        // Sprawdzenie czy tablica jest pusta
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Tablica liczb nie może być pusta");
        }

        // Obliczenie sumy wszystkich liczb w tablicy
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        // Obliczenie średniej
        double average = (double)sum / numbers.Length;
        return average;
    }
}