using System;

namespace VariablesExercise
{
    internal class Program
    {
        public static object If { get; private set; }

        static void Main(string[] args)
        {
            string name1 = "Josh";
            int age = 24;
            char middleInitial = 'M';
            bool isAMale = true;
            double weight = 165.4;

            string v = $"My name is {name1}. I am {age} years old.";

            Console.WriteLine(v);

            string b = $"My middle initial is {middleInitial}.";

            Console.WriteLine(b);

            if (isAMale)
            Console.WriteLine("I am a male.");

            Console.WriteLine($"I weigh {weight} pounds.");
        }
    }
}
