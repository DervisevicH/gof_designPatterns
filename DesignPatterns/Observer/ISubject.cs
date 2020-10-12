using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public interface ISubject
    {
        public void Subscribe(Student student);
        public void Unsubscribe(Student student);
        public void Notify();

    }
}
