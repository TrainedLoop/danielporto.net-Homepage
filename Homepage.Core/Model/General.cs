using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homepage.Core.Model
{
    public class General
    {
        public const string FirstName = "Daniel";
        public const string LastName = "Porto";
        public const string FullName = FirstName + " Santos " + LastName;
        static DateTime BirthDate = Convert.ToDateTime("07/01/1992");
        public static int Age = (DateTime.Now.DayOfYear < BirthDate.DayOfYear) ? (DateTime.Now.Year - BirthDate.Year) - 1 : (DateTime.Now.Year - BirthDate.Year);
    }
}
