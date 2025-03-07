namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1

            int[] numbers = { 1, 2, 3, 4, 5 };
            int biggestNumber = 0;

            for (int i = 0; i < numbers.Length; i++)
            {

                if (numbers[i] > biggestNumber)
                {
                    biggestNumber = numbers[i];
                }

            }

            Console.WriteLine(biggestNumber);

            //task 2

            int[] numbers1 = { 1, 3, 5, 7, 9 };
            bool flag = false;

            Console.Write("Input a number for n :");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; numbers1.Length > 0; i++)
            {
                if (n > numbers1[i])
                {
                    Console.WriteLine(n > numbers1[i]);
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                Console.WriteLine(flag);
            }

            //task 3

            string[] words = { "lorem", "ipsum", "car" };

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == "ipsum")
                {
                    Console.WriteLine($"{i + 1}. soz ipsumdur!");
                }
            }

            //task 4

            Console.Write("Birinci soz sonra herf daxil edin:");
            string word = Console.ReadLine();
            char letter = char.Parse(Console.ReadLine());
            bool checkBox = false;

            for (int i = 0; word.Length > i; i++)
            {
                if(word[i] == letter)
                {
                    Console.WriteLine($"{word} sozunun icinde {letter} herfi var");
                    checkBox = true;
                    break;
                }
                
            }

            if (!checkBox)
            {
                Console.WriteLine($"{word} sozunun icinde {letter} herfi yoxdur");
            }

        }
    }
}
