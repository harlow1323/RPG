/*
rpg by harlow

Pseudocode
	GS1 
	Output intro to the screen
Maintenance Log:
05/1/2023	start
            write intro

5/2/2023    make player class
            wrote hp and damage
            make name

5/3/2023   made items and main menu 
           game loop

5/9/23      move method and rooms
            make methods
            make classes
            added stuff to classes
			
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
            Console.WriteLine("u lost stuff from ur bag go find ur things ");
            Console.WriteLine("code by harlow");
            string? userInput = Console.ReadLine();

            do
            {
                Console.WriteLine("to enter the game type \"start\", to pick items type \"inventory\"");


                if (userInput == "start")
                {
                    GameLoop();
                }
                else if (userInput == "inventory")
                {

                }
            } while (userInput != "exit");
           
        }

        static void GameLoop()
        {
            string? userInput = Console.ReadLine();
            do
            {
                Console.WriteLine("pick a direction to go by typing \"North\", \"East\", \"South\", or \"West\"");


                    if (userInput == "North")
                {

                }
                else if (userInput == "East")
                {

                }
                else if (userInput == "South")
                {

                }
                else if (userInput == "West")
                {

                }
                    else
                {
                    Console.WriteLine("thats not a direction");
                }

            } while (userInput != "exit");
        }
    
    }

    internal class Player
    {

       static Random rng = new Random();
       static int minHp = 5, maxHp = 26;


        int hp = minHp + rng.Next(maxHp - minHp);

        static int minDamage = 1, maxDamage = 6;

        int damage = minDamage + rng.Next(maxDamage - minDamage);

        string name = "";

        List<Item> inventory = new List<Item>();
        
        static void Attack()
        {

        }
        static void Move(string direction)
        {

        }
        static void ViewInventory()
        {

        }
        static void GrabItem(Item item)
        {

        }
        static void Talk(NPC name)
        {

        }
    }

    internal class Item
    {
        string name;
        string description;
        int damageBonus = 0;
        bool equipped = false;


    }

    internal class Room

    {
        string description;

    }

    internal class NPC
    {

    }
    internal class SaveGame
    { 
    }
}
