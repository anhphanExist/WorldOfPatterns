namespace ComputePasswordHash;

internal class Program
{
    static void Main(string[] args)
    {
        //==============
        // hard-coded params for testing
        string password = "Arke2099!";
        string fromDbPasswordHash = "Kiw0AyFFgfpIOxjpNNzxpq/KFPpeac2PMRw6xtg8lpQ=";
        string fromDbPasswordSalt = "5NLPUnQ0epcp3dsja161OQ==";
        //==============

        Console.WriteLine("Persisted Password Hash: " + fromDbPasswordHash);
        Console.WriteLine("Persisted Salt: " + fromDbPasswordSalt);

        using (var hmac = new System.Security.Cryptography.HMACSHA256(Convert.FromBase64String(fromDbPasswordSalt)))
        {
            // changes the string into byte and them computes the hash
            //byte[] computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            byte[] computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            Console.WriteLine("HMACSHA256 Key: " + Convert.ToBase64String(hmac.Key));
            Console.WriteLine("Computed Password: " + Convert.ToBase64String(computedHash));
        }

        Console.WriteLine(VerifyPasswordHash(password,
            Convert.FromBase64String(fromDbPasswordHash),
            Convert.FromBase64String(fromDbPasswordSalt)));

        Console.WriteLine("========================");

        Tuple<string, string> user = Register(password);

        Console.WriteLine("PasswordHash: " + user.Item1);
        Console.WriteLine("Salt: " + user.Item2);

        Console.WriteLine(VerifyPasswordHash(password, Convert.FromBase64String(user.Item1), Convert.FromBase64String(user.Item2)));
    }

    // this method is used to verify the password 
    private static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
    {
        using (var hmac = new System.Security.Cryptography.HMACSHA256(passwordSalt))
        {
            // changes the string into byte and them computes the hash
            byte[] computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            for (int i = 0; i < computedHash.Length; i++)
            {
                //compares the hashed password(user input) with the hashed password from the database
                if (computedHash[i] != passwordHash[i])
                    return false;
            }
        }

        return true;
    }

    // This method is used to register the users
    public static Tuple<string, string> Register(string password)
    {
        byte[] passwordHash, passwordSalt;

        CreatePasswordHash(password, out passwordHash, out passwordSalt);

        return new Tuple<string, string>(Convert.ToBase64String(passwordHash), Convert.ToBase64String(passwordSalt));
    }

    private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
    {
        using (var hmac = new System.Security.Cryptography.HMACSHA256())
        {
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        }
    }
}