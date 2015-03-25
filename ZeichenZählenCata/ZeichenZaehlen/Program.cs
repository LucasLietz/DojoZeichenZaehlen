namespace ZeichenZaehlen
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie einen Satz ein, wo die Zeichen gezählt werden sollen:\n");
            var input = Console.ReadLine();
            var counter = new Counter();
            var output = counter.CountCharactersOf(input);

            foreach (var character in output)
            {
                Console.WriteLine(character);
            }

            Console.Read();
        }
    }
}