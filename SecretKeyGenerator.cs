using System;
using System.Security.Cryptography;

public class SecretKeyGenerator
{
    public static string GenerateSecretKey(int length)
    {
        // Define the length of the secret key (in bytes)
        byte[] keyBytes = new byte[length];

        // Generate a random byte array
        using (var rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(keyBytes);
        }

        // Convert the byte array to a base64-encoded string (for easier storage and transmission)
        string secretKey = Convert.ToBase64String(keyBytes);

        return secretKey;
    }

    public static void Main(string[] args)
    {
        // Generate a secret key with a length of 32 bytes (256 bits)
        string secretKey = GenerateSecretKey(32);

        // Output the generated secret key
        Console.WriteLine("Generated Secret Key: " + secretKey);
    }
}
