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

			
*/


using System.Security.Cryptography;

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

    internal class Player
    {

       static Random rng = new Random();
       static int minHp = 5, maxHp = 26;


        int hp = minHp + rng.Next(maxHp - minHp);

        static int minDamage = 1, maxDamage = 6;

        int damage = minDamage + rng.Next(maxDamage - minDamage);

        string name = "";



    }
}