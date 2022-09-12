using System;
using System.Runtime;

namespace operators
{
    class Program
    {
        static sbyte score = 0;
        
        static void Main(string[] args)
        {
            
            byte yourNum; byte comNum;
            float reslt;
            int mod;
            bool win = false;
            Console.Write("Enter your number(0-10): ");
            yourNum = Convert.ToByte(Console.ReadLine());
            while(yourNum < 0 && yourNum > 10)
            {
                Console.Write("Please enter a valid number:");
                yourNum = Convert.ToByte(Console.ReadLine());
            }
            
            Random rnd = new Random();
            comNum = Convert.ToByte(rnd.Next(0,11));

            void game(){
                if(win)
                {
                    reslt = comNum / yourNum;
                    mod = comNum % yourNum;
                    Console.WriteLine("you win!");
                    Console.WriteLine("the division is: {0}", (reslt).ToString());
                    Console.WriteLine("computer's mod of your number is: {0}", (mod).ToString());
                }else
                {
                    if((yourNum - comNum) > 0)
                    {
                        reslt = (float)yourNum / (float)comNum;
                        mod = comNum % yourNum;
                        Console.WriteLine("try again, computer's number is: {0}", comNum);
                        Console.WriteLine("the division is: {0}", (reslt).ToString());
                        Console.WriteLine("your number's remaind of computer's  is: {0}", (mod).ToString());
                    }else
                    {
                        reslt = (float)comNum / (float)yourNum;
                        mod = yourNum % comNum;
                        Console.WriteLine("try again, computer's number is: {0}", comNum);
                        Console.WriteLine("the division is: {0}", (reslt).ToString());
                        Console.WriteLine("computer's mod of your number is: {0}", (mod).ToString());
                    }

                }
            }

            switch (yourNum - comNum)
            {
                case 0:
                win = true;
                game();
                break;
                
                case < 0:
                win = false;
                game();
                break;

                case > 0:
                win = false;
                game();
                break;
            }

            if(win == true)
            {
                score++;
                Console.WriteLine("your score: {0}", score.ToString());
            }else{
                score--;
                Console.WriteLine("your score: {0}", score.ToString());
            }
            Console.ReadKey();
        }
    }
}
