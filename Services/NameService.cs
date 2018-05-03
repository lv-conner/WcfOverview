using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class NameService : INameService
    {
        public string Hello(string name)
        {
            return name + "\tHello";
        }
    }
}
