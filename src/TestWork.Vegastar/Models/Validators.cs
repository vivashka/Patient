using System.Text.RegularExpressions;

namespace TestWork.Vegastar.Models
{
    public class Validators
    {
        public static bool ValidatePatronymicOptional(string patronymic)
        {
            if (patronymic == null || patronymic == "") return true;
            if (2 <= patronymic.Length & patronymic.Length <= 32) return true;
            return false;
        }

        public static bool ValidateNumber(string str, int len)
        {
            if (str == null || str == "" ) return true;
            if (len == str.Length & Regex.IsMatch(str, "[0-9]{"+len+"}")) return true; // Можно лучше, но пока так
            return false;
        }
        public static bool ValidateNumbericOptional(string str, int len)
        {
            if (str == null || str == "") return true;
            if (0 <= str.Length & str.Length <= len & Regex.IsMatch(str, "[0-9]{0," + len + "}")) return true;
            return false;
        }
    }
}
