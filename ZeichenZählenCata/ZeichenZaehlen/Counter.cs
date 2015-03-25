namespace ZeichenZaehlen
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// This method is the central logic for counting things.
    /// In this case we count the amount of strings in a sentence.
    /// </summary>
    public class Counter
    {
        public Dictionary<string, int> CountCharactersOf(string input)
        {
            var inputString = input;
            var dictionary = new Dictionary<string, int>();

            var zwischenliste = inputString.Select((t, zaehler) => inputString.Substring(zaehler, 1)).ToList();

            foreach (var character in zwischenliste)
            {
                if (character == zwischenliste[0] || !dictionary.ContainsKey(character))
                {
                    dictionary.Add(character, 1);
                }
                else
                {
                    int valueOfEntry;
                    dictionary.TryGetValue(character, out valueOfEntry);
                    dictionary.Remove(character);
                    dictionary.Add(character, valueOfEntry + 1);
                }
            }
            return dictionary;
        }
    }
}