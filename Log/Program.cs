using System;

namespace Log
{
    class Program
    {
        static void Main(string[] args)
        {
            logfunct obj = new logfunct();
            obj.info("This is an information about something.");
            obj.error("We can't divide any numbers by zero.");
            obj.notice("Someone loves your status.");
            obj.warning("Insufficient funds.");
            obj.debug("This is debug message.");
            obj.allert("Achtung! Achtung!");
            obj.critical("We can't divide any numbers by zero.");
            obj.emergency("ystem hung. Contact system administrator immediately!.");

            obj.build("D:/");
            obj.print();
        }
    }
}
