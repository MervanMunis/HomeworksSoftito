namespace Work
{
    public class Program
    {
        private static string[] units = { "sıfır", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
        private static string[] teen = { "on", "on bir", "on iki", "on üç", "on dört", "on beş", "on altı", "on yedi", "on sekiz", "on dokuz" };
        private static string[] teens = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
        private static string[] thousands = { "", "bin", "milyon", "milyar" };
        public static void Main(string[] args)
        {
            for (int i = 1; i<=4; i++) 
            {
                Console.WriteLine("Enter a value: ");
                long num = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine(ToWords(num));
            }
        }

        public static string ToWords(long number)
        {
            string words = "";

            bool sign = false;

            if (number == 0)
            {
                Console.WriteLine("sıfır");
            }

            if (number < 0)
            {
                sign = true;
                number *= -1;
            }

            long[] thousandsDigits = new long[thousands.Length];

            // number = 1234567890 Örnepin [890, 567, 234, 1]
            for (int i = 0; i < thousands.Length; i++)
            {
                thousandsDigits[i] = number % 1000;
                number /= 1000;
            }

            for (int i = thousandsDigits.Length - 1; i >= 0; i--)
            {
                if (thousandsDigits[i] == 0)
                {
                    continue;
                }
                words += ChangeDigitStep(thousandsDigits[i]) + " " + thousands[i] + " ";
            }

            if (sign)
            {
                return "eksi " + words;
            }
            else
            {
                return words;
            }
        }

        private static string ChangeDigitStep(long number)
        {
            string result = "";

            if (number >= 100)
            {
                if (number / 100 > 1)
                {
                    result += units[number / 100] + " yüz ";
                }
                else
                {
                    result += "yüz ";
                }
                number %= 100;
            }

            if (number >= 20)
            {
                result += teens[number / 10] + " ";
                number %= 10;
            }

            if (number >= 10)
            {
                result += teen[number - 10] + " ";
            }
            else if (number > 0)
            {
                result += units[number] + " ";
            }
            return result.Trim();
        }
    }
}

// 7890
// 1234
// +
// 9124