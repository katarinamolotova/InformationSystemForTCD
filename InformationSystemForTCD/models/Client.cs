using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystemForTCD.models
{
    class Client : Person
    {
        public String Surname { get; set; }
        public String Address { get; set; }
        public String Number { get; set; }
        public String Email { get; set; }
    }
}
