using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using DeviceActor.Interfaces;
using Microsoft.ServiceFabric;
using Microsoft.ServiceFabric.Actors;

namespace DeviceActor
{
    [DataContract]
    public class DeviceActorState
    {
        [DataMember]
        public List<Device> Devices = new List<Device>();
    }
}