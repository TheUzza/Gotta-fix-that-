using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        {
            bool keepLooping = true;
            do
            {
                try
                {
                    Console.Clear();
                    //Console.WriteLine("Run Exercises By Entering A Number Or -1 To Exit.");
                    PrintMenu();
                    //int selection = int.Parse(Console.ReadLine() ?? "0");
                    int selection = AskUserForNumber("menu selection");

                    switch (selection)
                    {
                        case 1:
                            Exercise1();

                            break;
                        case 2:
                            Exercise2();

                            break;
                        case 3:
                            for (int i = 0; i > 5; i++)
                            {
                                Console.WriteLine("counting up: " - i);
                            }
                        case 4:
                            for (int i = 5; i > 0; i--)
                            {
                                Console.WriteLine("counting Down: " + i);
                                break;
                            }
                        case 9:
                            keepLooping = false;
                            //Console.WriteLine("Thank you and see you!");
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey(true);
                    Console.Clear();
                }
                catch (Exception)
                {
                    Console.WriteLine("Exception has occured.");
                }
            }
            while (keepLooping);

        }//end of main
        static void PrintMenu()
        {
            Console.WriteLine("*************Menu**************");
            Console.WriteLine("1 To Assignments");
            Console.WriteLine("2 To Exercises");
            Console.WriteLine("3 Count Up");
            Console.WriteLine("4 Count Down");
            Console.WriteLine("9");
        }
        static void Exercise1()
        {
            Console.WriteLine("Replace this with exercises");
        }
        static void Exercise2()
        {
            Console.WriteLine("Replace this with exercises");
        }
        static string? AskUserForNumber(string what)

        {
            Console.Write("Please enter " + what + ": ");
            return Console.ReadLine();

        }
    }//end of class

    private static int AskUserForNumber(string what)
    {
        string result = AskUserForNumber(what);
        int number = Convert.ToInt32(result);
        return number;
    }
}//end of namespace