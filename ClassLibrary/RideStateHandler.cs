using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public delegate void RideStateHandler(object sender, RideEventArgs e);
    public class RideEventArgs
    {
        public string message { get; private set; }

        public RideEventArgs(string _message)
        {
            message = _message;
        }
    }
}
