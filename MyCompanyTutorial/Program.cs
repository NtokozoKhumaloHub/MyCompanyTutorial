using System;

namespace MyCompanyTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Trainee myTrainee = new Trainee(12, 15);

            myTrainee.Learn();
            Console.ReadKey();
            myTrainee.Stop();

            Console.ReadLine();

            Console.WriteLine("Hello World!");
        }
    }
}
