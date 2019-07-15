using System;


namespace lab2
{
    class Program
    {

        static void Main(string[] args)
        {

            string inputYN = ("y");
            double userLength = 0;
            double userWidth = 0;
            bool isInvalidInput = true;

            while (inputYN == "y")
            {
                Console.WriteLine("Welcome to the Grand Circus' Room Detail Generator!");
                Console.WriteLine("Enter Length of the room ");


                while (isInvalidInput)
                {

                    string userInput = Console.ReadLine();
                    //double.TryParse((Console.ReadLine()), out userLength);
                    //foreach (var item in userInput)
                    //{
                    //    if (item == '\'')
                    //    {
                    //        Console.WriteLine("foot");
                    //    }
                    //    else if (item =='\"' )
                    //        { Console.WriteLine("inch");
                    //    }
                    //}

                    if (double.TryParse(userInput, out userLength))
                    {
                        {
                            if (userInput == "0")
                            {
                                Console.WriteLine("Humm, not sure if 0ft will work, try again");
                            }
                            else
                            {
                                isInvalidInput = false;
                            }
                        }
                    }
                    else

                    {
                        Console.WriteLine("Please enter a valid number for Length of the room. For example 24'6\" as 24.5");
                    }
                }

                isInvalidInput = true;

                Console.WriteLine("Enter the Width of the room");

                while (isInvalidInput)
                {
                    string userInput = Console.ReadLine();


                    if (double.TryParse(userInput, out userWidth))
                    {
                        if (userInput == "0")
                        {
                            Console.WriteLine("Humm, not sure if 0ft will work, try again");
                        }
                        else
                        {
                            isInvalidInput = false;
                        }
                    }

                    else
                    {
                        Console.WriteLine("Please enter a valid number for Width of the room. For example 24'6\" as 24.5");
                    }


                }

                isInvalidInput = true;


                double area = userLength * userWidth;
                double perimeter = 2 * userLength + 2 * userWidth;
                double volume = userLength * userWidth * 12; // assuming height of GC rooms are 12 feet high

                Console.WriteLine($"The Area of the room is {area} square feet");
                Console.WriteLine($"The perimeter of the room is {perimeter} feet");
                Console.WriteLine($"The volume of the room is {volume} cubic feet");

                Console.WriteLine("Continue? ([y]/[n])");
                while (isInvalidInput)
                {


                    inputYN = Console.ReadLine();

                    if (inputYN == ("y") || inputYN == ("n"))
                    {
                        isInvalidInput = false;

                    }

                    else
                    {
                        Console.WriteLine("please enter ([y]/[n]) format to continue or exit");

                    }
                }
                isInvalidInput = true;



            }



        }

    }
}
