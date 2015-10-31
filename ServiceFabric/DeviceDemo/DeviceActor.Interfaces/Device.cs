using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DeviceActor.Interfaces
{
    [DataContract]
    public class Device
    {
        [DataMember]
        public string DeviceID
        {
            get;
            set;
        }

        [DataMember]
        public SwitchStatusDefine SwitchStatus
        {
            get;
            set;
        }

        [DataMember]
        public double Temperature
        {
            get;
            set;
        }

        [DataMember]
        public DateTime UpdateTime
        {
            get;
            set;
        }
    }
}
