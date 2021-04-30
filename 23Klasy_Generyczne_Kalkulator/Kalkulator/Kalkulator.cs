using System;
using System.Collections.Generic;
using System.Text;

namespace _23Klasy_Generyczne_Kalkulator
{
    class Kalkulator<T>
    {
        public T Dodaj(T firstNumber, T secondNumber) {
            dynamic first = firstNumber;// zmienna dynamiczna
            dynamic second = secondNumber;// zmienna dynamiczna
            return first + second;
        }

        public T Odejmij(T firstNumber, T secondNumber)
        {
            dynamic first = firstNumber;// zmienna dynamiczna
            dynamic second = secondNumber;// zmienna dynamiczna
            return first - second;
        }

        public T Pomnoz(T firstNumber, T secondNumber)
        {
            dynamic first = firstNumber;// zmienna dynamiczna
            dynamic second = secondNumber;// zmienna dynamiczna
            return first * second;
        }

        public T Podziel(T firstNumber, T secondNumber)
        {
            dynamic first = firstNumber;// zmienna dynamiczna
            dynamic second = secondNumber;// zmienna dynamiczna
            return first/second;
        }
    }
}
