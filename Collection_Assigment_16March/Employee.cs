using System;
using System.Collections.Generic;
using System.Text;

namespace Collection_Assigment_16March
{
   public class Employee
    {
        int e_id;
        string e_name;

        public Employee(int e_id,string e_name)
        {
            this.e_id = e_id;
            this.e_name = e_name;
        }
        public override string ToString()
        {
            return e_id + " " + e_name;
        }
    }
}
