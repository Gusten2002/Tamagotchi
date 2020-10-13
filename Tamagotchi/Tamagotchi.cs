using System;
using System.Collections.Generic;

namespace Tamagotchi
{
    public class Tamagotchi
    {
        private static Random generator = new Random();

        private int hunger = 10;

        private int boredom = 10;

        private List<string> words = new List<string>();

        private bool isAlive = true;

        public string name = ("");
        
        public void Feed()
        {
            if (hunger >= 0)
            {
                hunger +=1;
                Console.WriteLine("You fed your Tamagotchi");
            }

            else
            {
                Console.WriteLine(name + " is full");
            }
        }

        public void Hi()
        {
            if (words.Count >= 1)
            {
                int whatWord = generator.Next(words.Count);

                string sayWord = words[whatWord];

                Console.WriteLine(sayWord);
                
                ReduceBoredom();
            }
            else
            {
                Console.WriteLine(name + " don't know any words");
                Console.WriteLine("You need to teach your Tamagotchi words");
            }

        }

        public void Teach(string word)
        {
            words.Add(word);
            ReduceBoredom();
        }

        public void Tick()
        {
            hunger -= 1;
            boredom -= 1;

            if(hunger <= 0 || boredom <= 0)
            {
                isAlive = false;
            }
        }

        public void PrintStats()
        {
            Console.WriteLine(name + " har:");
            Console.WriteLine(hunger + "/10 Hunger");
            Console.WriteLine(boredom + "/10 Boredom");

            if(isAlive == true)
            {
                Console.WriteLine("Your abomenation is alive");
            }
            else
            {
                Console.WriteLine("Your creature is dead");
            }
        }

        public bool GetAlive()
        {
            return isAlive;
        }

        private void ReduceBoredom()
        {
            if (boredom >= 0)
            {
                boredom += 1;
                Console.WriteLine(name + " is not as bored.");
            }
            else
            {
                Console.WriteLine(name + " is not bored at all.");
            }
            
        }
    }
    
}
