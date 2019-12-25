using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class Sample : ISample
    {
        public string GetAll()
        {
            return "DI in Class Library Successfull";
        }
    }
}
