﻿namespace ExpressionsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;
            int num3 = 30;

            int sum = 0;
            int mul = 1;
            int div = 0;
            int mod = 0;

            int result1 = 0;
            int result2 = 0;
            int result3 = 0;

            sum = num1 + num2;
            mul = num1 * num2;
            div = num1 / num2;
            mod = num1 % num2;

            result1 = sum++; // result = 30, sum = 31
            result1 = sum + 1;

            result3 = --num2; // result3 = 19, num2 = 19

            result2 = result2 + 5;
            result2 += 5;

            result3 = num1 > 0 ? 1 : 0;
            result3 = Math.Abs(num3);
        }
    }
}
