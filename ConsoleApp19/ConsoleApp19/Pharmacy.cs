using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp19
{
    class Pharmacy
    {
       public Medicine[] Medicines = new Medicine[0];
      

        public void AddMedicine(Medicine medicines)
        {
            Array.Resize(ref Medicines, Medicines.Length + 1);
            Medicines[Medicines.Length - 1] = medicines;
        }

       

        
    }
}
