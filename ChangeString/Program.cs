using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //Inputs pedidos no ínicio
            Console.Write("Write a phrase: ");
            string phrase = Console.ReadLine();
            Console.Write("Write a character: ");
            string character = Console.ReadLine();

            //Conversão da letra para Char
            char character_to_char = char.Parse(character);

            //Substituição e recolocação
            string modified = phrase.Replace(character_to_char,'x');
            Console.WriteLine(modified);
        }
    }
}
