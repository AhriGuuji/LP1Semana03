using System;
using System.Reflection.Metadata.Ecma335;

namespace TrapAnalyzer
{
    public class Program
    {
        /// <summary>
        /// Main method. Do not change it!
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        private static void Main(string[] args)
        {
            // DO NOT CHANGE THIS METHOD!
            TrapType trap = Enum.Parse<TrapType>(args[0]);
            PlayerGear gear = ParseGear(args);
            bool survives = CanSurviveTrap(trap, gear);
            DisplayResult(trap, survives);
            // DO NOT CHANGE THIS METHOD!
        }

        /// <summary>
        /// Parse the command line arguments to get the player gear.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        /// <returns>The player gear.</returns>
        private static PlayerGear ParseGear(string[] args)
        {
            PlayerGear gear = 0;
            foreach (string a in args)
            {
                if (Enum.Parse<PlayerGear>(a) == PlayerGear.Boots) gear |= PlayerGear.Boots;
                if (Enum.Parse<PlayerGear>(a) == PlayerGear.Shield) gear |= PlayerGear.Shield;
                if (Enum.Parse<PlayerGear>(a) == PlayerGear.Helmet) gear |= PlayerGear.Helmet;
            }
            
        }

        /// <summary>
        /// Can the player survive the trap given the gear it has?
        /// </summary>
        /// <param name="trap">The trap the player falls into.</param>
        /// <param name="gear">The gear the player has.</param>
        /// <returns>Wether the player survived the trap or not.</returns>
        private static bool CanSurviveTrap(TrapType trap, PlayerGear gear)
        {
            if (trap == TrapType.PoisonGas && gear == PlayerGear.Helmet) return true;
            if (trap == TrapType.PoisonGas && gear == PlayerGear.Shield) return true;
            if (trap == TrapType.LavaPit && gear == PlayerGear.Boots) return true;
            if (trap == TrapType.FallingRocks && gear == PlayerGear.Helmet) return true;
            if (trap == TrapType.SpinningBlades && gear == PlayerGear.Shield) return true;
        }

        /// <summary>
        /// Display information on wether the player survived the trap or not.
        /// </summary>
        /// <param name="trap">The trap the player has fallen into.</param>
        private static void DisplayResult(TrapType trap, bool survives)
        {
            Console.WriteLine($"{survives} {trap}");
        }
    }
}
