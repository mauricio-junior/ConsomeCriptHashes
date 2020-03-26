using System;

namespace ConsoleAppConsomeCriptHashes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#### Consuming CriptHashes!");

            CriptHashes.Hash hash = new CriptHashes.Hash();
            
            Console.WriteLine("my name is Mauricio Junior 512 = " + hash.GetHash("my name is Mauricio Junior", CriptHashes.Enum.HashType.SHA512));

            Console.WriteLine("my name is Mauricio Junior 384 = " + hash.GetHash("my name is Mauricio Junior", CriptHashes.Enum.HashType.SHA384));

            Console.WriteLine("my name is Mauricio Junior 256 = " + hash.GetHash("my name is Mauricio Junior", CriptHashes.Enum.HashType.SHA256));

            Console.WriteLine("my name is Mauricio Junior SHA1 = " + hash.GetHash("my name is Mauricio Junior", CriptHashes.Enum.HashType.SHA1));

            Console.Read();
        }
    }
}
