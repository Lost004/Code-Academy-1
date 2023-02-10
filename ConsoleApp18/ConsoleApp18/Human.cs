using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp18
{
    class Human
    {
        protected byte _age;
        public string Name;

        public virtual byte Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 0 && value <= 150)
                    _age = value;
            }
        }

    }
}
