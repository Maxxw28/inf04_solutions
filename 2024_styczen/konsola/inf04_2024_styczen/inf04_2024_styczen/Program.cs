internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Prosze podac pesel");
        //string pesel = "55030101193";
        string pesel = Console.ReadLine();
        Console.WriteLine(pesel);

        /*  Na egzaminie można zapomnieć w jaki sposób konwerotwać chara na int, na którym można
            wyknywać operacje, więc polecam poeksperymentować sobie na początku programu, aby
            szybko ogarnąć niezbędne funckje, czy opcje danej zmiennej */

        //Console.WriteLine((pesel[1] - '0') * 3);

        char plec = checkGender(pesel);
        if (plec == 'K') 
        { 
            Console.WriteLine("Kobieta"); 
        }
        else {
            Console.WriteLine("Mezczyzna"); 
        }

        if (checkPesel(pesel))
        {
            Console.WriteLine("Pesel zgodny");
        }
        else
        {
            Console.WriteLine("Pesel nie zgodny");
        }

    }
    //**********************************************
    //nazwa funkcji: checkGender
    //opis funkcji: sprawdza plec osoby o danym peselu
    //parametry: string pesel - 11 cyfrowy tekst będacy identyfikatorem osoby
    //zwracany typ i opis: char - typ znakowy, w zależności od poprawności 10 cyfry peselu zwraca informacje
    //  czy pesel wskazuje, że osoba jest Mężczyzna czy Kobietą (K/M)
    //autor: Maxxw28
    //***********************************************
    private static char checkGender(string pesel)
    {
        if (pesel[9] % 2 == 0)
        {
            return 'K';
        }else
        {
            return 'M';
        }
    }
    private static bool checkPesel(string pesel)
    {
        int[] peselWeights = new int[10] { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
        int S = 0;
        for (int i = 0; i < pesel.Length-1; i++)
        {
            S += (pesel[i] - '0') * peselWeights[i];
        }
        int M = S % 10;
        int R;
        if (M == 0)
        {
            R = 0;
        }
        else
        {
             R = 10 - M;
        }

        if (pesel[10]-'0' == R)
        {
            return true;
        }else
        {
            return false;
        }
    }
}