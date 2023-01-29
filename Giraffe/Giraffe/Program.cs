internal class Program
{
    private static void Main(string[] args)
    {
        string words = "Hello Mr. Bond.";
        string flipped = "";

        char[] splitWords = words.ToCharArray();
        
        for (int i = 0; i < splitWords.Length; i++)
        {
            string temp = splitWords[i].ToString();
            string inverse = "";
            if (temp == temp.ToLower())
               
                inverse = temp.ToUpper();
            if (temp == temp.ToUpper())
                inverse = temp.ToLower();

            flipped += inverse;
        }
        Console.WriteLine(flipped);
    }
}