using DeviceActor.Interfaces;
using Microsoft.ServiceFabric.Actors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceApplication.Client
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var proxy = ActorProxy.Create<IDeviceActor>(ActorId.NewId(), "fabric:/DeviceApplication");

            proxy.SubscribeAsync(new ClientDeviceEventHandler()).Wait();

            Device device = new Device() { DeviceID = "1001", SwitchStatus = SwitchStatusDefine.On, Temperature = 24, UpdateTime = DateTime.Now };

            string cmd = string.Empty;

            Random rnd = new Random((int)DateTime.Now.Ticks);

            Console.WriteLine("Please input command...");

            while (cmd.ToLower() != "exit")
            {
                switch (cmd.ToLower())
                {
                    case "write":
                        device.Temperature = rnd.NextDouble() * 100;
                        device.UpdateTime = DateTime.Now;

                        proxy.SetTelemetryAsync(device).Wait();
                        OutputDeviceInfo(proxy.GetActorId(), device);
                        Console.WriteLine("Data Written");
                        break;
                    case "read":
                        Device deviceRead = proxy.GetTelemetryAsync(device.DeviceID).Result;

                        if (deviceRead != null)
                            OutputDeviceInfo(proxy.GetActorId(), deviceRead);
                        break;
                }

                cmd = Console.ReadLine();
            }
        }

        private static void OutputDeviceInfo(ActorId actorID, Device device)
        {
            Console.WriteLine("Info from Actor {0}: Switch={1}, Temperature={2}, Time={3}",
                                actorID,
                                device.SwitchStatus,
                                device.Temperature,
                                device.UpdateTime);
        }
    }
}
