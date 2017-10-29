
namespace TechnicalShowcase
{
    using System;
    using TechnicalShowcase.BLLs;

    public static class InputBLL
    {
        public static string GetInput()
        {
            var input = Console.ReadLine();

            return input;
        }

        public static void HandleInput(string input)
        {
            if (!ValidateInput(input)) return;

            input = input.ToLower();

            if (input == "help")
            {
                DisplayHelp();
                return;
            }

            if (int.TryParse(input, out var n))
            {
                AlbumBLL.DisplayAlbumPhotos(n);
                Console.WriteLine("");
                Console.WriteLine("Please enter another command or album Id:");
            }
            else
            {
                Console.WriteLine("Sorry you did not enter a valid command or album Id. Please try again.");
            }
        }

        public static bool ExitProgram(string input)
        {
            return input.ToLower() == "exit";
        }

        private static bool ValidateInput(string input)
        {
            if (input == "" || input == null)
            {
                Console.WriteLine("You entered nothing. Please enter a valid command or album Id. Type 'help' to see commands.");
                return false;
            }
            return true;
        }

        private static void DisplayHelp()
        {
            Console.WriteLine("If you would like to exit the program simply type 'exit'");
            Console.WriteLine("If you would like to display the contents of an album please enter an id of the desired album.");
        }
    }
}
