using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSystemForTCD.models
{
    class Order
    {
        readonly ulong id;
        DateTime dateTime;
        Client client;
        Service service;
        Employee employee;
    }
}
