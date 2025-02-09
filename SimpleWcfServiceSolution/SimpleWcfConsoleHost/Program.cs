﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace SimpleWcfConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(SimpleWcfService.SimpleService)))
            {
                host.Open();
                Console.WriteLine("Host started @ " + DateTime.Now.ToLongDateString());
                Console.ReadLine();
            }
        }
    }
}
