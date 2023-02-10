using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp18
{
    class student:Human
    {
        
        public string GroupNo;
    
    public override byte Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 15 && value <= 65)

                    _age = value;


            }
        }
    }
}
