using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventuring
{
    class Encounters
    {
        static Random rand = new Random();
        //Encounter Generic

        //Encounters
        public static void FirstEncounter()
        {
            Console.WriteLine("You throw open the door, and demand to know where the hell you are. The man turns...");
            Console.WriteLine("He is surprised to see you alive and pulls out his knife to finish you off! \n" +
                "Press any key to prepare for battle!");
            Console.ReadKey();
            Combat(false, "Human Rouge", 1, 4);
        }
        //Encounter Tools
        //
        //
        public static void Combat(bool random, string name, int power, int health)
        {
            string n ="";
            int p = 0;
            int h = 0;
            if (random)
            {

            }
            else
            {
                n = name;
                p = power;
                h = health;
            }
            while(h> 0)
            {
                Console.Clear();
                Console.WriteLine(n);
                Console.WriteLine(p + "/" + h);
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine("| (A)ttack (D)efend |");
                Console.WriteLine("| (R)un    (H)eal   |");
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine("Potions: "+Program.currentPlayer.potion+"  Health: " + Program.currentPlayer.health);
                string userInput=Console.ReadLine();
                if(userInput.ToLower() =="a"|| userInput.ToLower() == "attack")
                {
                    //Attack
                    Console.WriteLine("You make a strong attack, the "+n+" strikes back");
                    int damage = p - Program.currentPlayer.armorValue;
                    if (damage < 0)
                        damage = 0;
                    
                    int attack = rand.Next(0, Program.currentPlayer.weaponValue) + rand.Next(1, 4);
                    Console.WriteLine("You lose " + damage + " health and deal "+ attack+"damage");
                    Program.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if (userInput.ToLower() == "d" || userInput.ToLower() == "defend")
                {
                    //Defend
                    Console.WriteLine("The " + n + " prepares his attack and you brace yourself");
                    int damage = p/4 - Program.currentPlayer.armorValue;
                    if (damage < 0)
                        damage = 0;

                    int attack = rand.Next(0, Program.currentPlayer.weaponValue)/2;
                    Console.WriteLine("You lose " + damage + " health and deal " + attack + "damage");
                    Program.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if (userInput.ToLower() == "r" || userInput.ToLower() == "run")
                {
                    //Run
                    if(rand.Next(0, 2)==0)
                    {
                        Console.WriteLine("You sprint away from the "+n+" and its strike catches you in the back!");
                        int damage = p - Program.currentPlayer.armorValue;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine("You lose " + damage + " health and are unable to escape.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("You successfully escape.");
                        Console.ReadKey();
                        //go to store
                    
                    }
                }
                else if (userInput.ToLower() == "h" || userInput.ToLower() == "heal")
                {
                    //Heal
                    if(Program.currentPlayer.potion == 0)
                    {
                        Console.WriteLine("You have no potions remaining.");
                        
                    }
                    else
                    {
                        Console.WriteLine("You consume 1 potion");
                        int potionV = 5;
                        Console.WriteLine("You gain "+potionV+"health");
                        Program.currentPlayer.health += potionV;
                    }
                    Console.ReadKey();
                }
                Console.ReadKey();
                

            }
        }
    }
}
