
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string jwt = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwMCIsIm5hbWUiOiJKb2huIERvZSIsImlhdCI6IjE2MzIzNTM5MjIifQ.ztSRW-HYOApb1dPyFPrIR7nxkCSeTP1UOjlNyuL_lgI";

        if (IsJwtValid(jwt))
        {
            Console.WriteLine("The given string is a valid JSON Web Token.");
        }
        else
        {
            Console.WriteLine("The given string is not a valid JSON Web Token.");
        }
    }

    static bool IsJwtValid(string jwt)
    {
        string pattern = @"^[\w\-]+\.[\w\-]+\.[\w\-]+$";
        Regex regex = new Regex(pattern);

        return regex.IsMatch(jwt);
    }
}
