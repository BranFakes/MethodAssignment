using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static int score;
        static int health;


        static void ShowHUD()
        {
            Console.WriteLine("===HUD===");
            Console.WriteLine("health = " + health);
            Console.WriteLine("DMG Taken -25");
            Console.WriteLine("score = " + score);
            Console.WriteLine("Score increased ");
            
            
            Console.WriteLine("=======");
            Console.WriteLine("");
        }
        static void TakeDamage()
        {
            health = health - 25;
        }
        static void AddScore()
        {
            score = score + 25;
        }
        static void scoreMultiplier()
        {
            score = score * 2;
        }
        static void KickedTheBucket()
        {
            if (health <= 0)
            {
                Console.WriteLine("You Kicked the Bucket");
            }

        }
    
            
        static void Main(string[] args)
        {
   
            health = 100;
            score = 100;
            ShowHUD();



            TakeDamage();
            AddScore();
            scoreMultiplier();
            
            ShowHUD();

            TakeDamage();
            AddScore();
            scoreMultiplier();

            ShowHUD();

            TakeDamage();
            AddScore();
            scoreMultiplier();

            ShowHUD();

            TakeDamage();
            AddScore();
            scoreMultiplier();
           
            ShowHUD();
            KickedTheBucket();



            Console.WriteLine();
            Console.WriteLine("==========");
            Console.WriteLine("*Dark Souls Death Sound*");
            Console.WriteLine("==========");


            Console.ReadKey();


        }
    }
}
