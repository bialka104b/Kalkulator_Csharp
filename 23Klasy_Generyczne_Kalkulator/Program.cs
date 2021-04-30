using System;

namespace _23Klasy_Generyczne_Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Kalkulator<float>();

            //WCZYTUJEMY OD UŻYTKOWNIKA LICZBE I PARSUJEMY
            Console.WriteLine("Wpisz pierwszą liczbę");
            var firstNumber = float.Parse(Console.ReadLine());
            Console.WriteLine("Wpisz drugą liczbę");
            var secondNumber = float.Parse(Console.ReadLine());

            Console.WriteLine("wpisz działanie które chcesz wykonać: '+' - dodawanie, '-' odejmowanie, '*' - mnożenie, '/' -dzielenie");
            var dzialanie = Console.ReadLine();

            var rezultat = default(float); //zmienna rezultat gdzie będzie przechowywany wynik. Zmienna ma domyślnie typ int
            switch (dzialanie)
            {
                case "+":
                    rezultat = calculator.Dodaj(firstNumber, secondNumber);
                    break;
                case "-":
                    rezultat = calculator.Odejmij(firstNumber, secondNumber);
                    break;
                case "*":
                    rezultat = calculator.Pomnoz(firstNumber, secondNumber);
                    break;
                case "/":
                    rezultat = calculator.Podziel(firstNumber, secondNumber);
                    break;
                default:
                    break;
            }
            //var sum = calculator.Dodaj(1, 2);
            Console.WriteLine("suma to " + rezultat);
        }
    }
}
