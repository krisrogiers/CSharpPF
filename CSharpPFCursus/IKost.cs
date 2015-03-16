using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Firma
{
    public interface IKost
    {
        decimal Bedrag
        {
            get;
        }

        bool Menselijk
        {
            get;
        }
        
    }
}
