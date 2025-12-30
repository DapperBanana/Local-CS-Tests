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
            // Validate token format
            var jwtToken = handler.ReadJwtToken(token);
            // Additional validation can be added here if necessary
            return true;
        }
        catch (ArgumentException)
        {
            // Token is not in a valid JWT format
            return false;
        }
        catch (FormatException)
        {
            // Token is not in a valid JWT format
            return false;
        }
        catch (Exception)
        {
            // Other exceptions mean invalid token
            return false;
        }
    }
}