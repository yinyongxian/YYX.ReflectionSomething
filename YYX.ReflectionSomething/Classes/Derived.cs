using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YYX.ReflectionSomething.Classes
{
    class Derived:Base
    {
        private string name;

        public Derived(string name)
        {

        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
