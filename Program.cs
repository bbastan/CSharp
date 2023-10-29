namespace exercise1_cw1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word: ");
            string word1 = Console.ReadLine();
            Console.WriteLine("Enter a other word: ");
            string word2 = Console.ReadLine();
            string result = (word1 == word2) ? "true" : "false";
            Console.WriteLine(result);
        }
    }
}