using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventuring
{
    class Program
    {
        public static Player currentPlayer = new Player();
       
        static void Main(string[] args)
        {
            Start();
            Encounters.FirstEncounter();
        }

        static void Start()
        {
            Console.WriteLine("Text Adventuring");
            Console.WriteLine("Name:");
            currentPlayer.name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You awake in a cold, dark room. You feel dazed and are having trouble remembering \nanything about your past.");
                if(currentPlayer.name == "")
            {
                Console.WriteLine("You can't even remember your own name...");
            }
            else
            {
                Console.WriteLine("You know your name is " + currentPlayer.name + ".");
            }
            Console.WriteLine("Press any key to look around");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You search for a way out of the room and find the door. You open the door and see a man\n" +
                " standing with his back to you outside the door.");

                
        }
    }
}
