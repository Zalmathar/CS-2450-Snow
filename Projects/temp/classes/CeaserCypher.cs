namespace classes.CeaserCypher;
public class CeaserCypher
{
    public static string encrypt(string message, char key) 
    {
        string nm = "";
        int keyVal = parseKey(key);
        
        // Encrypt the message
        foreach (char chr in message)
        {
            if(char.IsLetter(chr))
            {
                if(char.IsUpper(chr))
                {
                    nm += Convert.ToChar((((Convert.ToInt32(chr) + keyVal) - 65) % 26) + 65);
                }
                else
                {
                    nm += Convert.ToChar((((Convert.ToInt32(chr) + keyVal) - 97) % 26) + 97);
                }
            }
            else
            {
                nm += chr;
            }
        }
        return nm;
    }

    public static string decrypt(string message, char key)
    {
        string nm = "";
        int keyVal = parseKey(key);
        // Encrypt the message
        foreach (char chr in message)
        {
            if(char.IsLetter(chr))
            {
                if(char.IsUpper(chr))
                {
                    nm += Convert.ToChar(((((Convert.ToInt32(chr) + 26) - keyVal) - 65 ) % 26) + 65);
                }
                else
                {
                    nm += Convert.ToChar(((((Convert.ToInt32(chr) + 26) - keyVal) - 97) % 26) + 97);
                }
            }
            else
            {
                nm += chr;
            }
        }
        return nm;
    }

    private static int parseKey(char key)
    {
        if (char.IsLetter(key))
        {
            if (char.IsUpper(key))
            {
                return (Convert.ToInt32(key) - 64);
            }
            else if (char.IsLower(key))
            {
                return (Convert.ToInt32(key) - 96);
            }
            else
            {
                throw new Exception("Key was a letter but not lowercase or uppercase!");
            }
        }
        else 
        {
            throw new Exception("Key was Invalid");
        }
    }
}
