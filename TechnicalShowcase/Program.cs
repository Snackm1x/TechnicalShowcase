
namespace TechnicalShowcase
{
    using System;
    using TechnicalShowcase.DALs;

    class Program
    {
        static void Main(string[] args)
        {
            AlbumLoaderDAL.LoadAlbums();
            var runProgram = true;
            DisplayGreeting();
            while (runProgram)
            {
                var input = InputBLL.GetInput();

                if (InputBLL.ExitProgram(input))
                {
                    runProgram = false;
                }
                InputBLL.HandleInput(input);
            }

            void DisplayGreeting()
            {
                Console.WriteLine("Welcome to Alex's Techincal Showcase Photo Album!");
                Console.WriteLine("In order to see a list of options please type 'help'.");
                Console.WriteLine("In order to view an Album's content please enter the album Id:");
            }
        }
    }
}
