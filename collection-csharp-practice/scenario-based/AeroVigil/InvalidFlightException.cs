using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.senario_based.AeroVigil
{
    public class InvalidFlightException:Exception
    {
        public InvalidFlightException(string message) : base(message)
        {
        }
    }
}