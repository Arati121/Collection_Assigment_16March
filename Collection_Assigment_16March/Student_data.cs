using System;
using System.Collections.Generic;
using System.Text;

namespace Collection_Assigment_16March
{
    class Student_data
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.s_id = 101;
            s.s_name = "rahul";
            s.s_department = "IT";

            Console.WriteLine();
            Student s1 = new Student { s_id=102, s_name="Ram", s_department="Civil" };
           
        }
    }
}
