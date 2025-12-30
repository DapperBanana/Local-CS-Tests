using System;
using System.IdentityModel.Tokens.Jwt;

public class JwtValidator
{
    public static bool IsValidJwt(string token)
    {
        if (string.IsNullOrWhiteSpace(token))
            return false;

        var handler = new JwtSecurityTokenHandler();

        try
        {
            // Validate the token without checking the signature or expiration
            var jwtToken = handler.ReadJwtToken(token);
            // If reading succeeds, the token is structurally valid
            return true;
        }
        catch (ArgumentException)
        {
            // Token is not well-formed
            return false;
        }
        catch (FormatException)
        {
            // Token is not in a correct format
            return false;
        }
        catch (Exception)
        {
            // Other exceptions indicate invalid token
            return false;
        }
    }
}

// Example usage:
// Console.WriteLine(JwtValidator.IsValidJwt("your_jwt_token_here"));