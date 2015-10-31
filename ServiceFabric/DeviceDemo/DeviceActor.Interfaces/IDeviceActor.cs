using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Actors;

namespace DeviceActor.Interfaces
{
    public interface IDeviceActor : IActor, IActorEventPublisher<IDeviceEvents>
    //public interface IDeviceActor : IActor
    {
        Task SetTelemetryAsync(Device device);

        Task<Device> GetTelemetryAsync(string deviceID);
    }
}
