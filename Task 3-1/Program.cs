namespace Task_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zero = 0;
            Console.WriteLine("Enter numbers:");
            string numbers = Console.ReadLine();
            // якщо число від'ємне, то відрізаємо від нього мінус
            bool minusNumber = numbers.StartsWith("-");

            if (minusNumber)
            {
                numbers = numbers.Substring(1);
            }
            char[] result = numbers.ToCharArray();
            Array.Reverse(result);
            string reversedString = new string(result);
            //видалення нулів
            reversedString = reversedString.TrimStart('0');
            if (string.IsNullOrEmpty(reversedString))
            {
                reversedString = "0";
            }
            // якщо число було від'ємне, то після перетворення додаємо мінус назад         
            if (minusNumber)
            {
                reversedString = '-' + reversedString;
            }
            reversedString = reversedString.TrimStart('0');
            if (string.IsNullOrEmpty(reversedString))
            {
                reversedString = "0";
            }


            Console.WriteLine($"{reversedString}");
        }
    }
}
