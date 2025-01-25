using System.Text.RegularExpressions;

namespace Form_Validations
{
    public class Froms_Validations
    {
        public static bool ValidateEmail(string email)
        {
            var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";

            var regex = new Regex(pattern);

            return regex.IsMatch(email);

        }


        public static bool ValidateInteger(string Number)
        {
            var Pattern = @"^[0-9]+$";

            var regex = new Regex(Pattern);

            return regex.IsMatch(Pattern);
        }


        public static bool ValidateFloat(string Number)
        {
            var pattern = @"^[0-9]*(?:\.[0-9]*)?$";

            var regex = new Regex(pattern);

            return regex.IsMatch(Number);
        }

        public static bool IsNumber(string Number)
        {
            return (ValidateInteger(Number) || ValidateFloat(Number));
        }

    }
}
