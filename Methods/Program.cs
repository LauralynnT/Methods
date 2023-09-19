using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {

        static void HUD(float multiplier, float score, int health, int lives, int kills)
        {
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("----------");
            Console.WriteLine("Score Multiplier: " + multiplier + " | Score: " + score);
            Console.WriteLine("Health: " + health + " | Lives: " + lives);
            Console.WriteLine("Enemies Killed: " + kills);
            Console.WriteLine("----------");
            Console.ReadKey();
            Console.WriteLine("");
        }
        static int Damage(int health, int dmg)
        {
            return health - dmg;
        }
        static float ScoreMulti(float score, float multiplier)
        {
            return score * multiplier;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Sleep Deprived College Student Presents...");
            Console.WriteLine("Typical RPG HUD Simulator 2023!");
            Console.WriteLine("------------------------------------------");
            HUD(1.0f, 0, 100, 3, 0);
            float multiplier = 1.0f;
            float score = 0;
            int health = 100;
            int lives = 3;
            int kills = 0;

            Console.WriteLine("Player Takes 25 dmg");
            HUD(multiplier, score, Damage(health, 25), lives, kills);
            health = Damage(health, 25);

            Console.WriteLine("Player takes 50dmg");
            Console.WriteLine("Player kills 2 enemies");
            Console.WriteLine("Player gets 100pts");
            score += 100;

            HUD(multiplier, ScoreMulti(score, multiplier), Damage(health, 50), lives, kills+2);
            kills += 2;
            score += ScoreMulti(score, multiplier);
            health = Damage(health, 50);

            Console.WriteLine("Player kills 3 enemies");
            Console.WriteLine("Player gets 150pts");
            Console.WriteLine("5 enemies killed: score multiplier increased");
            Console.WriteLine("Player takes 25dmg");
            Console.WriteLine("Player died");
            multiplier = 1.25f;
            HUD(multiplier,ScoreMulti(150, multiplier)+score, Damage(health, 25), lives-1, kills+3);
            score += ScoreMulti(150, multiplier);
            health = Damage(health, 25);
            lives -= 1;
            kills += 3;

            Console.WriteLine("Player respawns");
            health += 100;
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("Player takes 75dmg");
            Console.WriteLine("Player kills 1 enemy");
            Console.WriteLine("Player gets 50pts");
            HUD(multiplier, ScoreMulti(50, multiplier)+score, Damage(health, 75), lives, kills + 1);
            score += ScoreMulti(50, multiplier);
            health = Damage(health, 75);
            kills += 1;

            Console.WriteLine("Player picks up health kit");
            Console.WriteLine("Player gains 50hp");
            health += 50;
            Console.WriteLine("Player kills 2 enemies");
            Console.WriteLine("Player gets 100pts");
            Console.WriteLine("Player takes 25dmg");
            HUD(multiplier, ScoreMulti(100, multiplier) + score, Damage(health, 25),lives, kills+2);
            score += ScoreMulti(100, multiplier);
            health = Damage(health, 25);
            kills += 2;

            Console.WriteLine("Player takes 25dmg");
            Console.WriteLine("Player kills 2 enemies");
            Console.WriteLine("Player gets 100pts");
            Console.WriteLine("10 enemies killed: score multiplier increased");
            multiplier += 0.25f;
            HUD(multiplier, ScoreMulti(100, multiplier) + score, Damage(health, 25), lives, kills + 2);

            Console.WriteLine("Goal Completed: Killed 10 Enemies");
            Console.WriteLine("Level Complete");
        }

    }
}
