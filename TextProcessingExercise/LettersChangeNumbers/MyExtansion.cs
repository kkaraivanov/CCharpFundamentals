namespace LettersChangeNumbers
{
    using System.Text.RegularExpressions;
    static class MyExtansion
    {
        public static void FromLetter(this ref decimal num, string ferst, string last)
        {
            if (IsBigerLetter(ferst))
                num /= GetLetterPosition(ferst);
            else
                num *= GetLetterPosition(ferst);

            if (IsBigerLetter(last))
                num -= GetLetterPosition(last);
            else
                num += GetLetterPosition(last);
        }

        static bool IsBigerLetter(string l)
        {
            return Regex.IsMatch(l, "[A-Z]");
        }

        static int GetLetterPosition(string l)
        {
            var lett = "abcdefghijklmnopqrstuvwxyz";

            return lett.IndexOf(l.ToLower()[0]) + 1;
        }
    }
}
