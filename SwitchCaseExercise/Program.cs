using System;

namespace SwitchCaseExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Who is your favorite motorcycle manufacturer?");

            var motoManu = Console.ReadLine();

        switch (motoManu.ToLower())
            {
                case "kawasaki":

                case "honda":

                case "yamaha":
                    Console.WriteLine("That ain't a Harley");
                    break;

                case "harley-davidson":

                case "harley davidson":

                case "harley":
                    Console.WriteLine("Hell yeah, brother. VROOM VROOM");
                    break;

                case "indian":
                    Console.WriteLine("HAHAHAHAHAHAHAHAHA");
                    break;
                default:
                    Console.WriteLine("Never heard of em");
                    break;


               

            }
        }
    }
}
