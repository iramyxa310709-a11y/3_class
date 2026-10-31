using System.Globalization;
using System.Text;


namespace _3_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Введіть рядок : ");
            string str = Console.ReadLine();
            Console.Write("Введіть рядок для вставки : ");
            string insertStr = Console.ReadLine();
            Console.Write("Введіть позицію : ");
            int pos = int.Parse(Console.ReadLine());

            StringBuilder builder = new StringBuilder(str);
            builder.Insert(pos, insertStr);
            Console.WriteLine($"Результат : {builder}");


            Console.WriteLine();
           
            Console.Write("Введіть число, слово або фразу : ");
            string text = Console.ReadLine();

            string[] parts = text.Split(new char[] { '.', ',', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string clean = string.Join("", parts).ToLower();

            StringBuilder reversed = new StringBuilder();
            for (int i = clean.Length - 1; i >= 0; i--)
            {
                reversed.Append(clean[i]);
            }

            if (clean == reversed.ToString())
            {
                Console.WriteLine("Це паліндром");
            }
            else
            {
                Console.WriteLine("Це не паліндром");
            }


            Console.Write("Введіть текст : ");
            string sentense = Console.ReadLine();

            int upperCount = 0;
            int lowerCount = 0;

            foreach (var let in sentense)
            {
                if (char.IsUpper(let))
                {
                    upperCount++;
                }
                if (char.IsLower(let))
                {
                    lowerCount++;
                }
            }

            Console.WriteLine($"Всього символів : {sentense.Length}");
            Console.WriteLine($"Великих літер : {upperCount}");
            Console.WriteLine($"Малих літер : {lowerCount}");

            Console.WriteLine();
         
            string[] sarray = { "Hello", "BYE", "Привіт", "ПАКА", "Вітання", "Прощання" };
            Console.Write("Введіть довжину слів : ");
            int length = int.Parse(Console.ReadLine());

            for (int i = 0; i < sarray.Length; i++)
            {
                if (sarray[i].Length == length && length >= 3)
                {
                    sarray[i] = sarray[i].Substring(0, sarray[i].Length - 3) + "$$$";
                }
            }

            string message = string.Join(" - ", sarray);
            Console.WriteLine($"Результат : {message}");
        }
    }
}
