using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkandla
{
    public class VisitorNotAllowedException:Exception
    {
        public VisitorNotAllowedException(string message)
            :base(message)
        {

        }

    }
}
