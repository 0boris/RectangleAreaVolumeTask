namespace RectangleAreaVolumeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This is a partially writen program in C#
            //to calculate the area of a rectangle or the volume of a box
            //from the user inputs
            //Complete the code in both the main program and in the function
            //so the program will take 3 user inputs and output either the area or volume
            // test your program with the following inputs
            //
            //| width   | length    | height |
            //|   5     |    6      |   -1   |
            //|   10    |    4      |    0   |
            //|   3     |    5      |    10  |
            //
            // Show your test evidence in the Readme

            int width, length, height = 0;
            Console.Write("Enter width: ");
            width = Convert.ToInt32(Console.ReadLine()); // added: convert to int
            Console.Write("Enter height (enter -1 to ignore): ");
            height = Convert.ToInt32(Console.ReadLine()); // added: variable assignment
            Console.Write("Enter length: "); // added: user prompt for length
            length = Convert.ToInt32(Console.ReadLine()); // added: variable assignment

            int answer = RectangleCalculator(width, length, height);
            if (height == -1)
            {
                Console.WriteLine($"Area = {answer}");
            }
            else
            {
                Console.WriteLine($"Volume = {answer}"); // added: other case if height is not -1, output volume (else statement)
            }
        }
        static int RectangleCalculator(int width, int length, int height)
        {

            if (height == -1) // if it is area
            {
                return width * length; // added: use formula for area to calculate + return.
            }
            else // if it is volume
            {
                return width * length * height; // added: use formula for volume to calculate + return.
            }
            // removed: unnecessary unreachable code
        }
    }
}
