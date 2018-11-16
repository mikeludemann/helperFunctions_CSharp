using System;
public class function
{
    public static double Sum(double[] array)
    {
        double result = 0;

        for (int i = 0; i < array.Length; i++)
        {
            result += array[i];
        }

        return result;
    }

    public static double power(double num, double exp)
    {
        double result = 1.0;
        int i;

        for (i = 1; i <= exp; i++)
        {
            result = result * num;
        }

        return result;
    }

    public static int Fibonacci(int number)
    {
        int firstNumber = 0;
        int secondNumber = 1;

        for (int i = 0; i < number; i++)
        {
            int temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp + secondNumber;
        }
        return firstNumber;
    }

    public static int sumFibonacci(int number)
    {
        if (number <= 2)
        {
            return 1;
        }
        else
        {
            return sumFibonacci(number - 1) + sumFibonacci(number - 2);
        }
    }

    public static int crossSum(int number)
    {
        string str = Convert.ToString(number);
        int sum = 0;

        for (int i = 0; i < str.Length; i++)
        {
            sum += Convert.ToInt32(str.Substring(i, 1));
        }

        return sum;
    }

    public static decimal Factorial(int number)
    {

        if (number == 0)
        {
            return 1;
        }

        else
        {
            return number * Factorial(number - 1);
        }
    }

}
