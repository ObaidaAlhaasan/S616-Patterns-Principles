using System;

namespace Design_Patterns_OOP.Strategy.ChatClient
{
    public class ChatClient
    {
        public void Send(string message, EncryptionAlgorithm encryptionAlgorithm)
        {
            var encryptedMsg = encryptionAlgorithm.Encrypt(message);
            Console.WriteLine("Sending the encrypted message... ");
        }
    }
}