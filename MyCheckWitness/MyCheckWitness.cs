using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services.Neo;

namespace Neo.SmartContract
{
    public class MyCheckWitness : Framework.SmartContract
    {
        //Token Settings
        public static readonly byte[] Owner = "AK2nJJpJr6o664CWJKi1QRXjqeic2zRp8y".ToScriptHash();
        public static readonly byte[] Owner2 = "031a6c6fbbdf02ca351745fa86b9ba5a9452d785ac4f7fc2b7548ca2a46c4fcf4a".HexToBytes();

        public static bool Main()
        {
            bool result = Runtime.CheckWitness(Owner);
            if (result)
            {
                Runtime.Notify("OWNER is caller");
                return true;
            }
            return false;
        }
    }
}

