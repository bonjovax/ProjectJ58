using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace nPOSProj.Conf
{
    class Crypto
    {
        private String getHash;

        //Send
        public String Hashed(String encode)
        {
            try
            {
                SHA512 hash = SHA512.Create();
                ASCIIEncoding encoder = new ASCIIEncoding();
                byte[] combined = encoder.GetBytes(encode);
                hash.ComputeHash(combined);
                getHash = Convert.ToBase64String(hash.Hash);
            }
            catch (Exception)
            {
                Console.WriteLine("NOT PRESENT!");
            }
            return getHash;
        }

        //Return
        public String retreiveHash()
        {
            return getHash;
        }

        public String RefHashed(String encode)
        {
            try
            {
                SHA1 hash = SHA1.Create();
                ASCIIEncoding encoder = new ASCIIEncoding();
                byte[] combined = encoder.GetBytes(encode);
                hash.ComputeHash(combined);
                getHash = Convert.ToBase64String(hash.Hash);
            }
            catch (Exception)
            {
                Console.WriteLine("NOT PRESENT!");
            }
            return getHash;
        }

        //Return
        public String RefretreiveHash()
        {
            return getHash;
        }
    }
}