class ProblemSet1
{
    static String MaxWord = "";
    static void MaxLengthWords(String input)
    {
        Console.WriteLine("==========Question 2c==========");
        int len = input.Length;
        int start = 0, end = 0;
        int max_length = 0, max_start_index = 0;
        while (end <= len)
        {
            if (end < len && input[end] != ' ')
            {
                end++;
            }
            else
            {
                int curr_length = end - start;
                if (curr_length > max_length)
                {
                    max_length = curr_length;
                    max_start_index = start;
                }
                end++;
                start = end;
            }
        }
        MaxWord = input.Substring(max_start_index, max_length);
    }
    public static void Main(String[] args)
    {
        String str = "Supercalifragilisticexpialidocious Honorificabilitudinitatibus Bababadalgharaghtakamminarronnkonn";
        MaxLengthWords(str);
        Console.Write(" Maximum length word : " + MaxWord);
    }
}