﻿using System;
using System.Diagnostics;
using System.Fabric;
using System.Threading;

namespace WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                using (FabricRuntime fabricRuntime = FabricRuntime.Create())
                {
                    // This is the name of the ServiceType that is registered with FabricRuntime. 
                    // This name must match the name defined in the ServiceManifest. If you change
                    // this name, please change the name of the ServiceType in the ServiceManifest.
                    fabricRuntime.RegisterServiceType("WebAPIType", typeof(WebAPI));

                    ServiceEventSource.Current.ServiceTypeRegistered(Process.GetCurrentProcess().Id, typeof(WebAPI).Name);

                    Thread.Sleep(Timeout.Infinite);
                }
            }
            catch (Exception e)
            {
                ServiceEventSource.Current.ServiceHostInitializationFailed(e);
                throw;
            }
        }
    }
}
