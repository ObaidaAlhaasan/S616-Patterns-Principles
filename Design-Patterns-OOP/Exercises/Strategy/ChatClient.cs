using System;
using Design_Patterns_OOP.Command.VideoEditor;
using Design_Patterns_OOP.Strategy.ChatClient;

namespace Design_Patterns_OOP.Exercises.Strategy
{
    public class ChatClient
    {
        public void Send(string message, EncryptionAlgorithm algorithm)
        {
            var encrypted = algorithm.Encrypt(message);

            Console.WriteLine("Sending the encrypted message..." + encrypted);
        }
    }

    public abstract class EncryptionAlgorithm
    {
        public abstract string Encrypt(string msg);
    }

    public class DesEncryption : EncryptionAlgorithm
    {
        public override string Encrypt(string msg) => "Encrypted" + msg;
    }

    public class AesEncryption : EncryptionAlgorithm
    {
        public override string Encrypt(string msg) => "Encrypted" + msg;
    }
}