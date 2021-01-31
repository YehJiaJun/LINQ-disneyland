using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disneyland.methon
{
    class variable
    {
        static string back = "";
        static string accountid = "";
        public string Back
        {
            get
            {
                return back;
            }
            set
            {
                back = value;
            }
        }
        public string Accid
        {
            get
            {
                return accountid;
            }
            set
            {
                accountid = value;
            }
        }
    }
}
