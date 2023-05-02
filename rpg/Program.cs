/*
rpg by harlow

Pseudocode
	GS1 
	Output intro to the screen
Maintenance Log:
05/1/2023	start
            write intro
			
*/


namespace rpg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GiveInstructions();

        }

        static void GiveInstructions()
        {
            Console.WriteLine("hi welcome to school ");
            Console.WriteLine("ulost stuff from ur bag go find ur things ");
            Console.WriteLine("code by harlow");
        }
    }
}