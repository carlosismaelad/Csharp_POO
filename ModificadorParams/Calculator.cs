using System;


namespace ModificadorParams
{
    public class Calculator
    {
        // Vamos ver 3 formas de criar uma calculadora de parâmetros, duas menos eficientes e outra usando 'params':

        /* #1: usando sobrecarga
        public static int Sum(int n1, int n2)
        {
            return n1 + n2;
        }
        public static int Sum(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }
        public static int Sum(int n1, int n2, int n3, int n4)
        {
            return n1 + n2 + n3 + n4;
        } */

        /* #2: usando vetores
        public static int Sum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        } */

        // #3: usando params
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }


    }
}