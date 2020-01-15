using System;
using System.Security.Cryptography;
using System.Text;

namespace MD5Sample {
    class Encrypt {
        static void Main (string[] args) {
            Console.WriteLine ("Enter your word to convert in MD5");
            string source = Console.ReadLine ();
            using (MD5 md5Hash = MD5.Create ()) {
                Console.WriteLine ("your encrypt code is" + Md5_encrypt (md5Hash, source));
            }

            Console.WriteLine ("Enter your word to convert in SHA1");
            string source1 = Console.ReadLine ();
            Console.WriteLine ("your encrypt code is" + sha1_encrypt (source1));

            Console.WriteLine ("Enter your word to convert in SHA256");
            string source2 = Console.ReadLine ();
            Console.WriteLine ("your encrypt code is" + sha256_encrypt (source2));

            Console.WriteLine ("Enter your word to convert in SHA512");
            string source3 = Console.ReadLine ();
            Console.WriteLine ("your encrypt code is" + sha512_encrypt (source3));
        }
        static string Md5_encrypt (MD5 md5Hash, string input) {
            byte[] data = md5Hash.ComputeHash (Encoding.UTF8.GetBytes (input));
            StringBuilder sBuilder = new StringBuilder ();
            for (int i = 0; i < data.Length; i++) {
                sBuilder.Append (data[i].ToString ("x2"));
            }
            return sBuilder.ToString ();
        }

        static string sha1_encrypt (string input) {
            using (SHA1Managed sha1 = new SHA1Managed ()) {
                var hash = sha1.ComputeHash (Encoding.UTF8.GetBytes (input));
                var sb = new StringBuilder (hash.Length * 2);

                foreach (byte b in hash) {
                    // can be "x2" if you want lowercase
                    sb.Append (b.ToString ("X2"));
                }
                string get = sb.ToString ();
                return get.ToLower ();
            }
        }

        public static string sha256_encrypt (string sValue) {
            StringBuilder oResHash = new StringBuilder ();
            using (SHA256 oHash = SHA256Managed.Create ()) {
                Encoding oEnc = Encoding.UTF8;
                byte[] baResult = oHash.ComputeHash (oEnc.GetBytes (sValue));
                foreach (byte b in baResult)
                    oResHash.Append (b.ToString ("x2"));
            }
            return oResHash.ToString ();
        }

        public static string sha512_encrypt (string input) {
            var bytes = System.Text.Encoding.UTF8.GetBytes (input);
            using (var hash = System.Security.Cryptography.SHA512.Create ()) {
                var hashedInputBytes = hash.ComputeHash (bytes);

                // Convert to text
                // StringBuilder Capacity is 128, because 512 bits / 8 bits in byte * 2 symbols for byte 
                var hashedInputStringBuilder = new System.Text.StringBuilder (128);
                foreach (var b in hashedInputBytes)
                    hashedInputStringBuilder.Append (b.ToString ("X2"));
                string hasil = hashedInputStringBuilder.ToString ();
                return hasil.ToLower ();
            }
        }
    }
}