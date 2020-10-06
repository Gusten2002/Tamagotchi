using System;
using System.Collections.Generic;

namespace Tamagotchi
{
    public class Tamagotchi
    {
        private Random generator = new Random();

        private int hunger = 0;

        private int boredom = 0;

        private List<string> words = new List<string>();

        private bool isAlive = true;

        public string name = Console.ReadLine();
        
        public void Feed()
        {
            if (hunger >= 0)
            {
                hunger -=10;
                Console.WriteLine("You fed your Tamagotchi");
            }

            else
            {
                Console.WriteLine("Your Tamagotchi is full");
            }
        }
        public void Hi()
        {
            if (words.Count >= 1)
            {
                int whatWord = generator.Next();

                string sayWord = words[whatWord];

                Console.WriteLine(sayWord);

                ReduceBoredom();
            }
            else
            {
                Console.WriteLine("Your Tamagotchi don't know any words");
                Console.WriteLine("You need to teach your Tamagotchi words");
            }

        }
        public void Teach(string word)
        {
            words.Add(word);
        }
        public void Tick()
        {

        }
        public void PrintStats()
        {

        }
        public void GetAlive()
        {

        }
        private void ReduceBoredom()
        {
            if (boredom >= 0)
            {
                boredom -= 10;
                Console.WriteLine("Your Tamagotchi is not as bored.");
            }

            else
            {
                Console.WriteLine("Your Tamagotchi is not bored at all.");
            }
            
        }
    }
    
}
