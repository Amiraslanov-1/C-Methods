using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp27
{
    class Departament
    {
         public  int EmployeLimit;
         private  Employe[] _employes;
        public Departament()
        {
            _employes = new Employe[0];
        }



        public  void AddEmploye(Employe employe)
        {

            if (employe.Length < EmployeLimit)
            {
                Array.Resize(ref employe, employe.Length + 1)

            }


        }

    }
}
