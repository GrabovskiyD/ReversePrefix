namespace ReversePrefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "abcd";

            char ch = 'z';

            Console.WriteLine(ReversePrefix(word, ch));
        }

        public static string ReversePrefix(string word, char ch)
        {
            System.Text.StringBuilder sb = new();
            for(int i = word.IndexOf(ch); i >= 0; i--)
            {
                sb.Append(word[i]);
            }
            for (int i = word.IndexOf(ch) + 1; i < word.Length; i++)
            {
                sb.Append(word[i]);
            }
            return sb.ToString();
        }
    }
}