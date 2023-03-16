//https://www.codewars.com/kata/517abf86da9663f1d2000003/csharp

string TCC(string input)
{
    List<string> strings = new List<string>();
    int cursor = 0;
    int i = 0;
    while (i < input.Length)
    {
        if (input[i] == '_' || input[i] ==  '-')
        {
            strings.Add(input.Substring(cursor, i-cursor));
            cursor = i + 1;
            Console.WriteLine(cursor);
        }
        i++;
        if (i == input.Length)
        {
            strings.Add(input.Substring(cursor, i - cursor));
        }

    }
    for (i = 1; i < strings.Count; i++)
    {
        char c = char.ToUpper(strings[i][0]);
        strings[i] = c + strings[i].Substring(1, strings[i].Length - 1);
    }
        return string.Join("", strings);
}

Console.WriteLine(TCC("the_stealth-warrior"));
Console.WriteLine(TCC("The-Stealth-Warrior"));

