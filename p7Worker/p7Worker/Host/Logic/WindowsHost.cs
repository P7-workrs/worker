using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using p7Worker.Host.Interfaces;

namespace p7Worker.Host.Logic
{
    internal class WindowsHost : IHost
    {
        public void MimicMachineFailur()
        {
            Thread.Sleep(1);
        }
    }
}
