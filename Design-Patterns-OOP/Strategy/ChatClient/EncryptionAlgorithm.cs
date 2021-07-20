using System;

namespace Design_Patterns_OOP.Strategy.ChatClient
{
    public abstract class EncryptionAlgorithm
    {
        public abstract string Encrypt(string msg);
    }

    public class DES : EncryptionAlgorithm
    {
        public override string Encrypt(string msg)
        {
            Console.WriteLine("Encrypting message using DES");
            return $"Encrypted {msg}";
        }
    }

    public class AES : EncryptionAlgorithm
    {
        public override string Encrypt(string msg)
        {
            Console.WriteLine("Encrypting message using AES");
            return $"Encrypted {msg}";
        }
    }

    public class UnsupportedOperationException : Exception
    {
        public UnsupportedOperationException(string unsupportedEncryptionAlgorithm) => throw new Exception(unsupportedEncryptionAlgorithm);
    }
}