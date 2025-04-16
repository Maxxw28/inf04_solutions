using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Ile kostek chcesz rzucić?(3-10)");
            int numberOfDices = int.Parse(Console.ReadLine());

            if (numberOfDices >= 3 && numberOfDices <= 10)
            {
                int[] tab = Wylosuj(numberOfDices);

                int totalSum = ObliczSume(tab);
                
                Console.WriteLine("Liczba uzyskanych punktów: " + totalSum);

                Console.WriteLine("Jeszcze raz? (t/n)");
                string choice = Console.ReadLine();
                if (choice == "n")
                {
                    break;
                }
            }
            
        }
    }
    public static int[] Wylosuj(int numberOfDices)
    {
        int[] tempTab = new int[numberOfDices];
        Random random = new Random();
        for (int i = 1; i <= numberOfDices; i++)
        {
            int diceValue = random.Next(1, 7);
            tempTab[i - 1] = diceValue;
            Console.WriteLine("Kostka" + i + ": " + diceValue);
        }
        return tempTab;
    }
    public static int ObliczSume(int[] tab)
    {
        Dictionary<int, int> counts = new Dictionary<int, int>();
        foreach (int number in tab)
        {
            if (counts.ContainsKey(number))
            {
                counts[number]++;
            }
            else
            {
                counts[number] = 1;
            }
        }

        int totalSum = 0;
        foreach (var kvp in counts)
        {
            int number = kvp.Key;
            int count = kvp.Value;

            if (count > 1)
            {
                totalSum += number * count;
            }
        }
        return totalSum;
    }
    //Alternatywny sposób na wykonanie operacji na tablicy oraz zwrócenie sumy nie unikalnych wartości
    public static int ObliczSume2(int[] tab)
    {
        return tab
            .GroupBy(x => x)
            .Where(g => g.Count() > 1)
            .Sum(g => g.Key * g.Count());
    }
}