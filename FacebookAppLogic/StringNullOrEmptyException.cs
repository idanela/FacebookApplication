using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookAppLogic
{
    public class StringNullOrEmptyException: Exception
    {
        public StringNullOrEmptyException(string i_Msg):base(i_Msg)
        {
            
        }
    }
}
