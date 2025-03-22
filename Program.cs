using System.Diagnostics;

namespace Palindrone_Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool  isPalindrone = true;
            
            while (true)
            {
                Console.Write("Please enter The Word To Check:");
                string word = Console.ReadLine();
               var aword= word.ToLower();
                for (int i = 0; i < aword.Length / 2; i++)
                {


                    if (aword[i] != aword[word.Length - i - 1])
                    {
                        isPalindrone = false;
                        break;
                    }
                }
                Console.WriteLine($"is Palindrone : {isPalindrone}");

            }
        }
    }
}
