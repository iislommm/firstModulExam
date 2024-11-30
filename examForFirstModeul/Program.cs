
namespace examForFirstModeul
{
    internal class Program
    {
        static void Main(string[] args)
        {//1
            //Console.Write("Enter word : ");
            //var word = Console.ReadLine();
            //var result = LastFourDigits(word);
            //Console.WriteLine(result);
            //2
            Console.Write("Enter length : ");
            var length = int.Parse(Console.ReadLine());
            var result = GetAndFillList(length);
            CountOddElements(result);
            Console.WriteLine(result);
            //3
            //Console.Write("Enter word : ");
            //var word = Console.ReadLine();
            //var result = LastG10(word);
            //Console.WriteLine(result);
            //4
            //Console.Write("Enter length : ");
            //var size = int.Parse(Console.ReadLine());
            //var result = GetAndFillListString(size);
            //moreThanThreeDigits(result);
            //Console.WriteLine(result);

        }

       

        public static string LastFourDigits(string text)
        {
            var result = text.Substring(0, text.Length - 4);
            return result;
        }
        public static void CountOddElements(List<int> numbers)
        {
            var oddCounter = 0;
            for (var i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    oddCounter++;
                }
            }
            Console.WriteLine($"amount of odd numbers : {oddCounter}");
        }
        public static List<int> GetAndFillList(int length)
        {
            var digit = new List<int>();
            for (var i = 0; i < length; ++i)
            {
                Console.Write($"{i}. Enter element : ");
                var number = int.Parse(Console.ReadLine());
                digit.Add(number);
            }
            return digit;

        }
        public static bool LastG10(string word)
        {
            if (word.EndsWith("g_10"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void moreThanThreeDigits(List<string> words)
        {
            var counter = 0;
            foreach (var word in words)
            {
                if (word.Length > 3)
                {
                    counter++;
                }

            }
            if (counter == words.Count)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false); ;
            }
        }
        public static List<string> GetAndFillListString(int length)
        {
            var words = new List<string>();
            for (var i = 0; i < length; i++)
            {
                Console.Write($"{i}. enter element : ");
                var word = Console.ReadLine();
                words.Add(word);
            }
            return words;

        }
    }
}
