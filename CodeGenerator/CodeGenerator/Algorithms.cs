using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Algorithms
    {

        public static string GeneratorCode()
        {
            string includeCharachters = "ACDEFGHKLMNPRTXYZ234579";
            Random random = new Random();
            StringBuilder resultStringBuilder = new StringBuilder();

            for (int i = 0; i < 8; i++)
            {
                if (i < 5)
                {
                    long TimeTicks = DateTime.Now.Ticks;
                    int item = int.Parse(TimeTicks.ToString().Substring(17));
                    resultStringBuilder.Append(includeCharachters[random.Next(item)]);
                }
                else
                    resultStringBuilder.Append(includeCharachters[random.Next(includeCharachters.Length)]);
            }
            return resultStringBuilder.ToString();
        }

        public static bool CheckCode(string code)
        {
            Regex rg = new Regex("^([ACDEFGHKLMNPRTXYZ234579]{8})");
            return rg.IsMatch(code);
        }

    }
}
