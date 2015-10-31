using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DeviceActor.Interfaces;
using Microsoft.ServiceFabric;
using Microsoft.ServiceFabric.Actors;
using System.Runtime.Serialization;

namespace DeviceActor
{
    public class DeviceActor : Actor<DeviceActorState>, IDeviceActor
    {
        private const string reminderName = "Pay the bill";

        public override Task OnActivateAsync()
        {
            if (this.State == null)
            {
                this.State = new DeviceActorState();
            }

            ActorEventSource.Current.ActorMessage(this, "State initialized to {0}", this.State);
            return Task.FromResult(true);
        }

        public Task SetTelemetryAsync(Device device)
        {
            int index = this.State.Devices.FindIndex(t => t.DeviceID == device.DeviceID);

            if (index == -1)
                this.State.Devices.Add(device);
            else
                this.State.Devices[index] = device;

            var ev = GetEvent<IDeviceEvents>();
            ev.DeviceStatusChanged(device.DeviceID, device.SwitchStatus);

            return Task.FromResult(true);
        }

        public Task<Device> GetTelemetryAsync(string deviceID)
        {
            Device found = this.State.Devices.SingleOrDefault(t => t.DeviceID == deviceID);

            return Task.FromResult(found);
        }
    }
}
