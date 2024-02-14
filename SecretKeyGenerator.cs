using System;
using System.Security.Cryptography;

public class SecretKeyGenerator
{
    public static string GenerateSecretKey(int length)
    {
        
        byte[] keyBytes = new byte[length];

        
        using (var rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(keyBytes);
        }

        
        string secretKey = Convert.ToBase64String(keyBytes);

        return secretKey;
    }

    public static void Main(string[] args)
    {
        
        string secretKey = GenerateSecretKey(32);

       
        Console.WriteLine("Generated Secret Key: " + secretKey);
    }
}
