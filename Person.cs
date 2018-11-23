using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project.Properties
{
    class Person
    {
        /*
             * Person class:
             * Fields: string: FirstName, MiddleInitial, LastName, Birthdate, and Address.
             * Empty Methods: string: GetFullName and int: GetAge.
         */

        public string FirstName;
        public string MiddleInitial;
        public string LastName;
        public string Birthdate;
        public string Address;

        public string GetFullName()
        {
            return "Empty";
        }

        public int GetAge()
        {
            return 0;
        }


    }
}
