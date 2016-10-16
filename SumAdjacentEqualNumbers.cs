using System;
using System.Collections.Generic;
using System.Linq;

public class SumAdjacentEqualNumbers
{
    public static void Main()
    {
        List<double> numbers = new List<double>();
        string input = Console.ReadLine();
        List<string> list = input.Split(' ').ToList();
        for (int i = 0; i < list.Count; i++)
        {
            numbers.Add(double.Parse(list[i]));
        }

        int index = 0;

        while (index < numbers.Count - 1)
        {
            if (numbers[index] == numbers[index + 1])
            {
                numbers[index] = numbers[index] + numbers[index + 1];
                numbers.RemoveAt(index + 1);
                if (index > 0) // връщаме брояча с една позиция, защото като премахнем елемент, трябва да проверяваме и следващия
                {
                    index--;
                }
            }
            else
            {
                index++;
            }

        }


        Console.WriteLine(string.Join(" ", numbers));
    }
}