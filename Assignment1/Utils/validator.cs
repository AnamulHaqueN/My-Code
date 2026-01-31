using System.Text.RegularExpressions;

class Validator
{
    public static bool IsEmpty(string value) => string.IsNullOrWhiteSpace(value);

    public static bool IsValidEmail(string email)
    {
        string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        return Regex.IsMatch(email, pattern);
    }

    public static bool IsValidPhone(string phone)
    {
        return phone.Length == 11 && long.TryParse(phone, out _);
    }
}
