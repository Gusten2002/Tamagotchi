using System.Threading;
using System;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            Tamagotchi tamagotchi = new Tamagotchi();

            Console.WriteLine("What will you name your tamagotchi?");
            
            tamagotchi.name = Console.ReadLine();

            Console.WriteLine(tamagotchi.name + ", what a lovley name!");
            
            sleep();

            while(tamagotchi.GetAlive() == true)
            {
                tamagotchi.PrintStats();

                sleep();

                Console.WriteLine("please choosewhat you want to do with " + tamagotchi.name +
                "\n[Teach]" +
                "\n[Feed]" +
                "\n[Speak]");
                // + "\n[Kill it!]"
                // + "\n[add another]"

                string answer = Console.ReadLine();

                if(answer.ToLower() == "teach")
                {
                    Console.WriteLine("Word to teach");
                    tamagotchi.word = Console.ReadLine();
                    
                    tamagotchi.Teach();
                }

            }

            Console.ReadLine();
        }

        public static void sleep()
        {
            Thread.Sleep(2000);
        }
    }
}
