using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    abstract class Colleague
    {
        protected Mediator mediator;

        // Constructor

        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
