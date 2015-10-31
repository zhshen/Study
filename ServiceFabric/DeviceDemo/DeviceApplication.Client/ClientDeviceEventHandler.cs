using DeviceActor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceApplication.Client
{
    public class ClientDeviceEventHandler : IDeviceEvents
    {
        public void DeviceStatusChanged(string deviceID, SwitchStatusDefine switchStatus)
        {
            Console.WriteLine("Device {0} Status Changed: {1}", deviceID, switchStatus);
        }
    }
}
