using Microsoft.ServiceFabric.Actors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceActor.Interfaces
{
    public interface IDeviceEvents : IActorEvents
    {
        void DeviceStatusChanged(string deviceID, SwitchStatusDefine switchStatus);
    }
}
