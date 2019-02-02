using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsList.Model
{
    class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int IdDep { get; set; }

        public override string ToString()
        {
            return $"Id Department: {IdDep}; FirstName: {FirstName}; MiddleName: {MiddleName}; LastName: {LastName}";
        }
    }
}
