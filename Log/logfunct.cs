using System;
using System.IO;
using System.Text;

namespace Log {
    public class logfunct {
        private StringBuilder word = new StringBuilder ();
        private string date () {
            return DateTime.Now.ToString ();
        }

        public void info (string input) {
            word.Append (date () + " INFO : " + input + "\n");
        }

        public void error (string input) {
            word.Append (date () + " INFO : " + input + "\n");
        }

        public void notice (string input) {
            word.Append (date () + " INFO : " + input + "\n");
        }

        public void warning (string input) {
            word.Append (date () + " INFO : " + input + "\n");
        }

        public void debug (string input) {
            word.Append (date () + " INFO : " + input + "\n");
        }

        public void allert (string input) {
            word.Append (date () + " INFO : " + input + "\n");
        }

        public void critical (string input) {
            word.Append (date () + " INFO : " + input + "\n");
        }

        public void emergency (string input) {
            word.Append (date () + " INFO : " + input + "\n");
        }
        public void build (string path) {
            File.AppendAllText (path + "log.log", word.ToString ());
            word.Clear ();
        }

        public void print () {
            Console.WriteLine(word);
        }

    }
}