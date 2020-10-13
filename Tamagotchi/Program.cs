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
                "\n[Speak]" +
                "\n[Nothing]" );
                // + "\n[Kill it!]"
                // + "\n[add another]");

                string answer = Console.ReadLine();

                while(answer.ToLower() != "teach" && answer.ToLower() != "feed" && answer.ToLower() != "speak" && answer.ToLower() != "nothing")
                {
                    Console.WriteLine("Only accepting any of the four choices");
                    answer = Console.ReadLine();
                }

                if(answer.ToLower() == "teach")
                {
                    Console.WriteLine("Word to teach");
                    string learnWord = Console.ReadLine();
                    
                    tamagotchi.Teach(learnWord);
                }

                else if(answer.ToLower() == "feed")
                {
                    Console.WriteLine("You feed your tamagotchi");
                    tamagotchi.Feed();
                }

                else if(answer.ToLower() == "speak")
                {
                    tamagotchi.Hi();
                }

                if(answer.ToLower() == "nothing")
                {
                    Console.WriteLine("You did nothing.");
                }

                    tamagotchi.Tick();
                    
                    sleep();
                    Console.Clear();
            }

            Console.ReadLine();
        }

        public static void sleep()
        {
            Thread.Sleep(1500);
        }
    }
}
