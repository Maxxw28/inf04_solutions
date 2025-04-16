
using System.Diagnostics.CodeAnalysis;

internal class Program
{
    public class Tablica
    {
        private int[] tab;
        private int tabSize = 0;
        public Tablica(int n)
        {
            tab = new int[n];
            tabSize = tab.Length;

            Random random = new Random();
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = random.Next(1, 1001);
            }
        }
        public void Wypisz()
        {
            for (int i = 0; i < tabSize; i++)
            {
                Console.WriteLine(i + " : " + tab[i]);
            }
        }
        //**********************************************
        //nazwa metody: findIndexFun
        //opis metody: wyszukuje index w tablicy szukanego elementu
        //parametry: int element - jest to szukany przez funkcje element w tablicy
        //zwracany typ i opis: int - typ całkowity, zwracany jest index szukanego elementu w postaci
        //  liczby całkowitej
        //autor: Maksymilian Wyżykowski (normalnie nr pesel lub paszportu)
        //***********************************************
        public int findIndexFun(int element)
        {
            int index = Array.IndexOf(tab, element);
            return index;
        }

        public int LiczbaNieparzystych()
        {
            int sum = 0;
            for (int i = 0; i < tabSize; i++)
            {
                if (tab[i] % 2 != 0)
                {
                    Console.WriteLine(tab[i]);
                    sum++;
                }
            }
            return sum;
        }
        public int sredniaArtmetyczna()
        {
            int sum = 0;
            for (int i = 0; i < tabSize; i++)
            {
                sum += tab[i];
            }
            int srednia = sum / tabSize;
            return srednia;
        }
    }
    private static void Main(string[] args)
    {
        //Alternatywna opcja
        //Tablica tablica = new Tablica(21);
        Tablica tablica = new(21);
        
        tablica.Wypisz();

        int index = tablica.findIndexFun(320);
        if (index != -1)
        {
            Console.WriteLine("znaleziono wartosc pod indexem: " + index);
        }

        Console.WriteLine("liczby nieparzyste:");
        int iloscNieparzystych = tablica.LiczbaNieparzystych();

        Console.WriteLine("Razem nieparzystych: " + iloscNieparzystych);

        Console.WriteLine("Średnia wszystkich elementów: " + tablica.sredniaArtmetyczna());
        
    }
}