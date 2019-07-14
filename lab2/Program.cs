using System;


namespace lab2
{
    class Program
    {

        static void Main(string[] args)
        {




            string inputYN = ("y");


            while (inputYN == "y")
            {
                Console.WriteLine("Welcome to the Grand Circus' Room Detail Generator!");
                Console.WriteLine("Enter Length");
                double userLength = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Width");
                double userWidth = double.Parse(Console.ReadLine());

                double area = userLength * userWidth;
                double perimeter = 2 * userLength + 2 * userWidth;
                double volume = userLength * userWidth * 12; // assuming height of GC rooms are 12 feet high

                Console.WriteLine($"The Area of the room is {area} square feet");
                Console.WriteLine($"The perimeter of the room is {perimeter} feet");
                Console.WriteLine($"The volume of the room is {volume} cubic feet");

                Console.WriteLine("Continue? (y/n)");
                inputYN = Console.ReadLine();

                //if (inputYN != "yes" or inputYN !="no")
                //{

                //}

            }


            //bool isInvalidLengthInput = true;
            //bool isInvalidWidthInput = true;

            //double userLength = 0;
            //double userWidth = 0;


            //string input = Console.ReadLine();

            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (input[i] == 'h' || input[i] == 'u')
            //    {
            //        Console.WriteLine($"you're input is {input[i]}, at index: {i}");
            //    }
            //}

            //while (isInvalidLengthInput)
            //{


            //    Console.WriteLine("Enter the length!");
            //    string userInputLength = Console.ReadLine();

            //    if (double.TryParse(userInputLength, out userLength))
            //    {
            //        isInvalidLengthInput = false;
            //    }
            //    else

            //    {
            //        Console.WriteLine("Please enter a number");
            //    }

            //}


            //while (isInvalidWidthInput)
            //{
            //    Console.WriteLine("Enter the Width!");
            //    string userInputWidth = Console.ReadLine();

            //    if (double.TryParse(userInputWidth, out userWidth))
            //    {
            //        isInvalidWidthInput = false;
            //    }
            //    else

            //    {
            //        Console.WriteLine("Please enter a number");
            //    }


            //}

            //Console.WriteLine($"The area of the room is {userLength*userWidth} square feet");
            //Console.WriteLine($"The perimeter of the room is {2*userLength+2*userWidth} feet");
        }

    }
}
