using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SucessResult:Result
    {
        public SucessResult(string message):base(true,message)
        {
            
        }
        public SucessResult():base(true)
        {
            
        }
    }
}
