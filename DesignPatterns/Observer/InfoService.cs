using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class InfoService: ISubject
    {
        private List<Student> students = new List<Student>();
        private List<string> events = new List<string>();
        public void AddEvent(string newEvent)
        {
            events.Add(newEvent);
            Notify();
        }
        public void Notify()
        {
            foreach (Student item in students)
            {
                item.Notify();
            }
        }

        public void Subscribe(Student student)
        {
            students.Add(student);
        }

        public void Unsubscribe(Student student)
        {
            students.Remove(student);
        }
    }
}
