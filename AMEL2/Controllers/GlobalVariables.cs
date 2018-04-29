using System;
using System.Web;

namespace AMEL2.Controllers
{
    public static class GlobalVariables
    {
        // readonly variable
        public static string Foo
        {
            get
            {
                return "foo";
            }
        }

        // read-write variable
        public static string Email
        {
            get
            {
                return HttpContext.Current.Application["Email"] as string;
            }
            set
            {
                HttpContext.Current.Application["Email"] = value;
            }
        }
    }
}
