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

5/11/23     room
            player and dungeon in game
            25 dungeon rooms
			
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
            Player player = new Player();
            List<Room> dungeon = new List<Room>()
            {
                new Room()
                 {
                 description = "",
                 items = new List<Item>() { },
                 NPCS = new List<NPC>() { },
            },
               new Room()
               {
                 description = " the room is cold and dim and covered in bugs",
                 items = new List<Item>() { },
                 NPCS = new List<NPC>() { },
               },
                new Room()
               {
                 description = "the room is chilly and hexagonal,lighted with candles and very dusty",
                 items = new List<Item>() { },
                 NPCS = new List<NPC>() { },
               }, new Room()
               {
                 description = "the room is mossy and fully dark and looks like a storage room",
                 items = new List<Item>() { },
                 NPCS = new List<NPC>() { },
               }, new Room()
               {
                 description = "the room is a triangle and covered in ash and lit by a fire in a corner",
                 items = new List<Item>() { },
                 NPCS = new List<NPC>() { },
               }, new Room()
               {
                 description = " the room is wooden and octagonal and pitch black with snakes hissing",
                 items = new List<Item>() { },
                 NPCS = new List<NPC>() { },
               }, new Room()
               {
                 description = "the room has oil lamps and the floor has blood and in the middle there is a tree",
                 items = new List<Item>() { },
                 NPCS = new List<NPC>() { },
               }, new Room()
               {
                 description = "the room has walls that are water damaged and its covered in vines and a glass roof making natural sunlight",
                 items = new List<Item>() { },
                 NPCS = new List<NPC>() { },
               }, new Room()
               {
                 description = "the room has a stench of vomit and the floor tiles each glowed a different color between the cracks",
                 items = new List<Item>() { },
                 NPCS = new List<NPC>() { },
               }, new Room()
               {
                 description = "the room has broken furniture and the tiled ceiling is leaking something",
                 items = new List<Item>() { },
                 NPCS = new List<NPC>() { },
               }, new Room()
               {
                 description = "the room is small and narrow and floral wallpaper drenched in oil on the walls ",
                 items = new List<Item>() { },
                 NPCS = new List<NPC>() { },
               }, new Room()
               {
                 description = "the room has a huge statue and the entire room is made of gold with a big chandalier",
                 items = new List<Item>() { },
                 NPCS = new List<NPC>() { },
               }, new Room()
               {
                 description = "the room is dark and echos and is fully empty",
                 items = new List<Item>() { },
                 NPCS = new List<NPC>() { },
               }, new Room()
               {
                 description = "the room has 5 jail cells on each side and each cell has a torch, a bed, and a sink",
                 items = new List<Item>() { },
                 NPCS = new List<NPC>() { },
               }, new Room()
               {
                 description = "the room is full of bookshelves and looks old with cobwebs and dusty books",
                 items = new List<Item>() { },
                 NPCS = new List<NPC>() { },
               }, new Room()
               {
                 description = "the room has quick sand with no lights",
                 items = new List<Item>() { },
                 NPCS = new List<NPC>() { },
               }, new Room()
               {
                 description = "the room has a bunch of animals in cages and lit by torches",
                 items = new List<Item>() { },
                 NPCS = new List<NPC>() { },
               }, new Room()
               {
                 description = "the room is oval and has a red carpet rug and with hundreds of paintings on the walls and a huge chandalier",
                 items = new List<Item>() { },
                 NPCS = new List<NPC>() { },
               }, new Room()
               {
                 description = "the room is made fully of brick and has a low ceiling",
                 items = new List<Item>() { },
                 NPCS = new List<NPC>() { },
               }, new Room()
               {
                 description = "the room is a storage room full of chests",
                 items = new List<Item>() { },
                 NPCS = new List<NPC>() { },
               }, new Room()
               {
                 description = "the room has creeky wooden floors with blood splatters and its pitch black",
                 items = new List<Item>() { },
                 NPCS = new List<NPC>() { },
               }, new Room()
               {
                 description = "the room is a circlular room with walls making a spiral path and there is one torch next to the enterence",
                 items = new List<Item>() { },
                 NPCS = new List<NPC>() { },
               }, new Room()
               {
                 description = "the room is an armory and decorated with bright uniquely shaped sheilds on one wall and the others with weapons and other items ",
                 items = new List<Item>() { },
                 NPCS = new List<NPC>() { },
               }, new Room()
               {
                 description = "the room is cold and the floor and walls are lightly covered in a layer of snow and ice with footprints in the snow",
                 items = new List<Item>() { },
                 NPCS = new List<NPC>() { },
               }, new Room()
               {
                 description = "",
                 items = new List<Item>() { },
                 NPCS = new List<NPC>() { },
               }, new Room()
              
            };
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
       public string name;
       public string description;
       public int damageBonus = 0;
       public bool equipped = false;


    }

    internal class Room

    {
       public string description;
       public List<Item>? items;
       public List<NPC>? NPCS;
    }

    internal class NPC
    {

    }
    internal class SaveGame
    { 
    }
}
