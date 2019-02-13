using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.Common
{
    public interface ILoggable
    {
        //no need access modifiers , no implementation
        string Log();
    }
}
