using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Caesar_Cipher {
    class Program {

        public static char cipher (char ch, int key) {
            if (!char.IsLetter (ch)) {
                return ch;
            }
            char d = char.IsUpper (ch) ? 'A' : 'a';
            return (char) ((((ch + key) - d) % 26) + d);
        }

        public static string Encipher (string input, int key) {
            string output = "";
            if(key == 12) {
                foreach (char ch in input)
                    output += cipher (ch, key);
            } else {
                Console.WriteLine ("you can't read the word");
            }
            return output;
        }

        public static string Decipher (string output, int key) {
            string hasil = Encipher (output, 26 - key);
            return hasil;
        }

        static void Main (string[] args) {

            Console.WriteLine ("Type a string to encrypt:");
            string UserString = Console.ReadLine ();

            Console.WriteLine ("\n");
            Console.Write ("Enter your Key \n");
            int key = Convert.ToInt32 (Console.ReadLine ());
            Console.WriteLine ("\n");

            Console.WriteLine ("Encrypted Data");
            string cipherText = Encipher (UserString, key);
            Console.WriteLine (cipherText);

            Console.WriteLine ("Decrypted Data:");
            Console.WriteLine (Decipher (cipherText, key));
            Console.Write ("\n");
        }
    }
}