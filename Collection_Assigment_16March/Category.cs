using System;
using System.Collections.Generic;
using System.Text;

namespace Collection_Assigment_16March
{
    class Category
    {
        int p_id;
        string p_name;

        public Category(int p_id,string p_name)
        {
            this.p_id = p_id;
            this.p_name = p_name;
        }

        public override string ToString()
        {
            return p_id + " " + p_name;
        }
    }
}
