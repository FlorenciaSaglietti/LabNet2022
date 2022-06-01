using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class Logic
    {
        public void DevuelveCE(string message)
        {
            throw new CustomException(message);
        }
        public void DevuelveEx() 
        {
            throw new Exception("Nueva excepcion");
        }
    }
}
