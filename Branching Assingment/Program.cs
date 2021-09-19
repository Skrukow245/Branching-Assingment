using System;


namespace Branching_Assiment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            int Weight = Convert.ToInt32(Console.ReadLine());
            if (Weight > 50)                //if the weight over 50 it will give this answer
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }      //is there an easier way to do this step without else statement? such as an end program after this part  
            else   //else statement to end the program if weight is over 50 otherwise will continute
            {      
                Console.WriteLine("Please enter the package width:");
                int Width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                int Height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                int Length = Convert.ToInt32(Console.ReadLine());
                if (Width + Height + Length > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }

                int quote = (Height * Width * Length * Weight / 100);   
                Console.WriteLine("Your estimated total for shipping this package is:$" + quote);
            }
            Console.ReadLine();
        }
    }
}
