using System.Text;

internal class Program
{
    private static readonly string _patternChar = "aeiou";
    private static readonly string _patternNums = "12345";
    private static void Main(string[] args)
    {
        Console.WriteLine(Encode("How are you today?"));
        Console.WriteLine(Decode("H4w 1r2 y45 t4d1y?"));
    }
    public static string Encode(string msg)
    {
        var sb = new StringBuilder();
        foreach (char c in msg) 
        {
            if (_patternChar.Contains(c))
            {
                sb.Append(_patternChar.IndexOf(c) + 1);
            }
            else
            {
                sb.Append(c);
            }
        }
        return sb.ToString();
    }

    public static string Decode(string msg)
    {
        var sb = new StringBuilder();
        foreach (char c in msg)
        {
            if (_patternNums.Contains(c))
            {
                sb.Append(_patternChar[int.Parse(c.ToString())-1]);
            }
            else
            {
                sb.Append(c);
            }
        }
        return sb.ToString();
    }
}