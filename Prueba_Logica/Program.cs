
using System.Reflection.PortableExecutable;

String input = Console.ReadLine();
Dictionary<char, int> output = new Dictionary<char, int>();




foreach (var character in input)
{
    if (output.ContainsKey(character))
    {
        output[character]++;
    }
    else
    {
        output.Add(character, 1);
    }
}
var reps = output.Values.ToList();

for (int i = 0; i < output.Count; i++)
{
    var num = reps[i];
    
    for (int j = i; j > 0; j--)
    {
        if (num > reps[j-1])
        {
            reps[j] = reps[j-1];
            reps[j-1] = num;
        }
    }
}
int start = 26, total = 0;
for (int i = 0; i < reps.Count; i++, start--)
{
    total += reps[i]*start;
}
Console.WriteLine(total);

