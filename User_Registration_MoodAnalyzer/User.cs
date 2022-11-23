using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User_Registration_MoodAnalyzer
{
    public class User
    {
        public bool FirstName(string name)
        {
            Regex firstName = new Regex(@"^([A-z]{1}[a-z]{2,})$");
            bool matches = firstName.IsMatch(name);


            return matches;
        }
    }
}
