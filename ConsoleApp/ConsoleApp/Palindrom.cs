using System.Text;

Console.WriteLine("Hello, World!");

String[] names = { "Kajak" };

/* static bool isPolindrom(String[] names)
{
    int nameLength = 0;

    if(names.Length <= 0)
    {
        return false;
    }
    for(int i = 0; i < names.Length; i++)
    {
        names[i] = names[i].Replace(" ", "").ToLower();
        nameLength = names[i].Length;
        var nameFromBack = new StringBuilder();

        for (int j = names[i].Length - 1; j = 0; j--) {
            nameFromBack.Append(names[j]);
        }
        Console.WriteLine(nameFromBack.ToString() + " + " + names[i]);
        
        if(names[i] == nameFromBack.ToString())
        {
            return true;
        }
    }
    return false;
}
*/

static bool IsPalindrom(string wordToCheck)
{
    if (String.IsNullOrEmpty(wordToCheck))
        return false;
    wordToCheck = wordToCheck
                  .Replace(" ", "")
                  .ToLower();

    int length = wordToCheck.Length;

    for (int i = 0; i < length / 2; i++)
    {
        if (wordToCheck[i] != wordToCheck[length - i - 1])
            return false;
    }
    return true;
}

Console.WriteLine(IsPalindrom("Kajak"));
