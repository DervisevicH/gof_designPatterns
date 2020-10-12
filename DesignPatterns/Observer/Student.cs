using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class Student : INotification
    {
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        
        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public void Notify()
        {
            Console.WriteLine("{0}You got new notification", FirstName + " " + LastName);
        }
    }
}
