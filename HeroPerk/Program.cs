using System;
using System.Linq;
using System.Security;

namespace HeroPerk
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string selectedPerk = args[0].ToLower(); //All args are lowered so CAPS doesn't bother it
            int[] count = new int [4]; //Array where it will save values of each char in args

            foreach (char c in selectedPerk) //for each char in args
            {
                switch(c)
                {
                    case 'w': //if char is w
                        count[0]++;
                        break;
                    case 'a': //if char is a
                        count[1]++;
                        break;
                    case 's': //if char is s
                        count[2]++;
                        break;
                    case 'd': //if char is d
                        count[3]++;
                        break;
                    default: //if char doesn't correspond to anything
                        Console.WriteLine($"!Unknown perk!");
                        return;
                }
            }

            Perks player = 0; //new null variable

            //it will check if the number of each char is divisible by 2. If not, it will add the right perk to player
            if (count[0] % 2 != 0) player |= Perks.WarpShift;
            if (count[1] % 2 != 0) player |= Perks.AutoHeal;
            if (count[2] % 2 != 0) player |= Perks.Stealth;
            if (count[3] % 2 != 0) player |= Perks.DoubleJump;
            //if the player has a perk, it will print what perk does it have
            if (player != 0) Console.WriteLine($"Player Perks: {player}");
            //if player stays at 0, it will print a warning
            if (player==0) Console.WriteLine("!No perks at all!");
            //if player has two specific perks, it will print a special print
            if ((player & Perks.Stealth) == Perks.Stealth && (player & Perks.DoubleJump) == Perks.DoubleJump) Console.WriteLine("!Silent jumper!");
            //if player has this specific perk, it will print this special print
            if ((player & Perks.AutoHeal) != Perks.AutoHeal) Console.WriteLine("!Not gonna make it!");
        }
    }

    [Flags]
    enum Perks
    {
        WarpShift = 1 << 0,
        AutoHeal = 1 << 1,
        Stealth = 1 << 2,
        DoubleJump = 1 << 3
    }
}
