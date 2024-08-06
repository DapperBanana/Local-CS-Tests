
using System;
using System.IdentityModel.Tokens.Jwt;

class Program
{
    static void Main()
    {
        string jwtString = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c";

        bool isValidJWT = IsValidJWT(jwtString);

        if (isValidJWT)
        {
            Console.WriteLine("The given string is a valid JSON Web Token.");
        }
        else
        {
            Console.WriteLine("The given string is not a valid JSON Web Token.");
        }
    }

    static bool IsValidJWT(string jwtString)
    {
        try
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.ReadToken(jwtString) as JwtSecurityToken;

            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}
