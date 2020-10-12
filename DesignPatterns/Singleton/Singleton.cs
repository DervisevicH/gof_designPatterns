using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public sealed class Singleton
    {
        private static Singleton _instance = null;
        public static Singleton GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }

        private Singleton() { }
    }
}
