using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEventArgs
{
    class ChangePasswordEventArgs
    {
        public string Passwordtext { get; set; }
        public string NewPasswordtext { get; set; }

    }
}
