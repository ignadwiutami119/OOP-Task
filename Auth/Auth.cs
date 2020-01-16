using System;

namespace Auth {
    public class Auth {

        public string info_us = "";
        public string info_pass = "";
        public bool info_log = false;
        public string id_user = "";
        public string Username = "";
        public string Password = "";
        public string lastLog = "never logged";

        public Auth (string username, string password, string id) {
            this.Username = username;
            this.Password = password;
            this.id_user = id;
        }

        public void login (string input_user, string input_password) {
            if (input_user == Username && input_password == Password) {
                info_us = input_user;
                info_pass = input_password;
                Console.WriteLine ("Login Success");
                lastLog = DateTime.Now.ToString ();
                info_log = true;
            } else {
                Console.WriteLine ("Login Failed");
            }
        }

        public void validate (string input_user, string input_password) {

            if (Username == input_user && Password == input_password) {
                Console.WriteLine ("This account available");
            } else {
                Console.WriteLine ("Username and Password didn't match");
            }
        }

        public void logout() {
            if(info_us != "") {
            info_us.Remove (0);
            info_pass.Remove (0);
            Console.WriteLine ("Logout Success"); }
            else {
            Console.WriteLine("You are not login yet");
            }
        }

        public void user () {
            Console.WriteLine ("user account : " + Username);
            Console.WriteLine ("password account : " + Password);
        }

        public void id () {
            if(info_us == "") {
                 Console.WriteLine("you are not login yet");
            }
            else {
                Console.WriteLine ("id account : " + id_user);
            }
        }

        public void check () {
            Console.WriteLine (info_log);
        }

        public bool guest () {
            bool stat = false;
            if (info_us == "") {
                Console.WriteLine ("You are a Guest");
                stat = true;
            } else {
                Console.WriteLine ("You are not Guest");
            }
            return stat;
        }

        public void lastLogin () {
            Console.WriteLine ("last login : " + lastLog);
        }
    }
}