using System;
using System.Linq;
using System.Security;

namespace HeroPerk
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string selectedPerk = args[0].ToLower();
            int[] count = new int [4];

            foreach (char c in selectedPerk)
            {
                switch(c)
                {
                    case 'w':
                        count[0]++;
                        break;
                    case 'a':
                        count[1]++;
                        break;
                    case 's':
                        count[2]++;
                        break;
                    case 'd':
                        count[3]++;
                        break;
                    default:
                        Console.WriteLine($"!Unknown perk!");
                        return;
                }
            }

            Perks player = 0;

            if (count[0] % 2 != 0) player |= Perks.WarpShift;
            if (count[1] % 2 != 0) player |= Perks.AutoHeal;
            if (count[2] % 2 != 0) player |= Perks.Stealth;
            if (count[3] % 2 != 0) player |= Perks.DoubleJump;
            if (player != 0) Console.WriteLine($"Player Perks: {player}");
            if (player==0) Console.WriteLine("!No perks at all!");
            if ((player & Perks.Stealth) == Perks.Stealth && (player & Perks.DoubleJump) == Perks.DoubleJump) Console.WriteLine("!Silent jumper!");
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
