using System;
using System.Collections.Generic;
using System.Linq;

class PokemonEvolution
{
    static void Main()
    {
        string input = Console.ReadLine();

        Dictionary<string, List<KeyValuePair<string, long>>> output = new Dictionary<string, List<KeyValuePair<string, long>>>();

        while (input != "wubbalubbadubdub")
        {
            string[] data = input.Split(new[] { '-', ' ', '>' }, StringSplitOptions.RemoveEmptyEntries);

            string name = data[0];

            if (data.Length > 1)
            {
                string type = data[1];
                long index = long.Parse(data[2]);

                if (!output.ContainsKey(name))
                {
                    output.Add(name, new List<KeyValuePair<string, long>>());
                }

                output[name].Add(new KeyValuePair<string, long>(type, index));
            }
            else
            {
                if (output.ContainsKey(name))
                {
                    Console.WriteLine("# " + name);

                    foreach (var item in output[name])
                    {
                        Console.WriteLine(item.Key + " <-> " + item.Value);
                    }
                }
            }

            input = Console.ReadLine();
        }

        foreach (var item in output)
        {
            Console.WriteLine("# " + item.Key);

            var ordered = item.Value.OrderByDescending(x => x.Value);

            foreach (var secondItem in ordered)
            {
                Console.WriteLine(secondItem.Key + " <-> " + secondItem.Value);
            }
        }
    }
}
