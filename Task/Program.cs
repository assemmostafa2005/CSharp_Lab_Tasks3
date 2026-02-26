using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n********************************************");
            Console.WriteLine("Enter Task Number (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 18, 19)");
            Console.WriteLine("Enter 0 to Exit.");
            Console.WriteLine("**********************************************");
            Console.Write("Choice: ");

            string choice = Console.ReadLine();
            if (choice == "0") break;

            Console.WriteLine("\n--- Output ---");
            switch (choice)
            {
                case "1": Task1(); break;
                case "2": Task2(); break;
                case "3": Task3(); break;
                case "4": Task4(); break;
                case "5": Task5(); break;
                case "6": Task6(); break;
                case "7": Task7(); break;
                case "8": Task8(); break;
                case "9": Task9(); break;
                case "10": Task10(); break;
                case "18": Task18(); break;
                case "19": Task19(); break;
                default: Console.WriteLine("Invalid choice!"); break;
            }
        }
    }

    // Task 1: Value type passing (Value vs Ref)
    static void Task1()
    {
        int a = 10, b = 10;
        ModifyValue(a, ref b);
        Console.WriteLine($"By Value: {a} (Unchanged), By Reference: {b} (Changed)");
    }
    static void ModifyValue(int x, ref int y) { x = 20; y = 20; }

    // Task 2: Reference type passing (Value vs Ref)
    static void Task2()
    {
        int[] arr1 = { 1 };
        int[] arr2 = { 1 };
        ModifyRef(arr1, ref arr2);
        Console.WriteLine($"By Value Array: {arr1[0]} (Old), By Reference Array: {arr2[0]} (New)");
    }
    static void ModifyRef(int[] x, ref int[] y)
    {
        x = new int[] { 99 };
        y = new int[] { 99 };
    }

    // Task 3: 4 parameters, return sum and sub
    static void Task3()
    {
        Calc(10, 5, out int sum, out int sub);
        Console.WriteLine($"Numbers: 10 and 5 -> Sum = {sum}, Sub = {sub}");
    }
    static void Calc(int x, int y, out int sum, out int sub) { sum = x + y; sub = x - y; }

    // Task 4: Sum of individual digits
    static void Task4()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        int sum = 0, temp = Math.Abs(num);
        while (temp > 0) { sum += temp % 10; temp /= 10; }
        Console.WriteLine($"The sum of the digits of {num} is: {sum}");
    }

    // Task 5: IsPrime function
    static void Task5()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        bool isPrime = true;
        if (num <= 1) isPrime = false;
        for (int i = 2; i <= Math.Sqrt(num); i++) { if (num % i == 0) { isPrime = false; break; } }
        Console.WriteLine(isPrime ? "True (Prime)" : "False (Not Prime)");
    }

    // Task 6: MinMaxArray using ref parameters
    static void Task6()
    {
        int[] arr = { 7, 2, 9, 1, 5 };
        int min = arr[0], max = arr[0];
        foreach (int i in arr) { if (i < min) min = i; if (i > max) max = i; }
        Console.WriteLine($"Array: {{7, 2, 9, 1, 5}} -> Min: {min}, Max: {max}");
    }

    // Task 7: Iterative Factorial
    static void Task7()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        long fact = 1;
        for (int i = 1; i <= num; i++) fact *= i;
        Console.WriteLine($"Factorial is: {fact}");
    }

    // Task 8: ChangeChar function
    static void Task8()
    {
        string str = "Hello";
        char[] chars = str.ToCharArray();
        chars[1] = 'a';
        Console.WriteLine($"Original: Hello -> Modified: {new string(chars)}");
    }

    // Task 9: Second largest element
    static void Task9()
    {
        int[] arr = { 10, 5, 20, 8, 15 };
        int max = int.MinValue, second = int.MinValue;
        foreach (int num in arr)
        {
            if (num > max) { second = max; max = num; }
            else if (num > second && num != max) { second = num; }
        }
        Console.WriteLine($"Array: {{10, 5, 20, 8, 15}} -> Second largest: {second}");
    }

    // Task 10: Longest distance between two equal cells
    static void Task10()
    {
        int[] arr = { 7, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3 };
        int maxDist = 0;
        for (int i = 0; i < arr.Length; i++)
            for (int j = i + 1; j < arr.Length; j++)
                if (arr[i] == arr[j] && (j - i - 1) > maxDist)
                    maxDist = j - i - 1;

        Console.WriteLine($"Array: {{7, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3}} -> Longest distance: {maxDist}");
    }

    // Task 18: Copy elements of first array to second array
    static void Task18()
    {
        int[,] arr1 = { { 1, 2 }, { 3, 4 } };
        int[,] arr2 = new int[2, 2];
        Console.WriteLine("Copied 2D Array:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                arr2[i, j] = arr1[i, j];
                Console.Write(arr2[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    // Task 19: Print 1D Array in Reverse Order
    static void Task19()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        Console.Write("Array reversed: ");
        for (int i = arr.Length - 1; i >= 0; i--) Console.Write(arr[i] + " ");
        Console.WriteLine();
    }
}