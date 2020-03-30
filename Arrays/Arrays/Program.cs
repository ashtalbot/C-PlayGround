using System;


namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 3, 7, 9, 2, 14, 6 };
            Console.WriteLine("New Array");

            foreach (var n in numbers)
                Console.WriteLine(n);

            // .Length
            Console.WriteLine("Length of Array: " + numbers.Length);


            // IndexOf()
            Array.IndexOf(numbers, 9);
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9:" + index);

            // Clear()
            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Clear(numbers) to position 2");
            foreach (var n in numbers)
                Console.WriteLine(n);

            // Copy()
            var dupe = new int[3];
            Array.Copy(numbers, dupe, 3);

            Console.WriteLine("dupe copy values");
            foreach (var n in dupe)
                Console.WriteLine(n);

            // Sort()
            Array.Sort(numbers);

            Console.WriteLine("Sorted Array");

            foreach (var n in numbers)
            Console.WriteLine(n);

            // Reverse()
            Array.Reverse(numbers);

            Console.WriteLine("Reversed Array");

            foreach (var n in numbers)
                Console.WriteLine(n);

        }
    }
}
