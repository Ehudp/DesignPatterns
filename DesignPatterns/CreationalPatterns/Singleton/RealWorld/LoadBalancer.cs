using System;
using System.Collections.Generic;

namespace DesignPatterns.CreationalPatterns.Singleton.RealWorld
{
    internal class LoadBalancer
    {
        private static LoadBalancer _instance;

        // Lock synchronization object
        private static readonly object syncLock = new object();
        private readonly Random _random = new Random();
        private readonly List<string> _servers = new List<string>();

        // Constructor (protected)
        protected LoadBalancer()
        {
            // List of available servers
            _servers.Add("ServerI");
            _servers.Add("ServerII");
            _servers.Add("ServerIII");
            _servers.Add("ServerIV");
            _servers.Add("ServerV");
        }

        // Simple, but effective random load balancer
        public string Server
        {
            get
            {
                int r = _random.Next(_servers.Count);
                return _servers[r];
            }
        }

        public static LoadBalancer GetLoadBalancer()
        {
            // Support multithreaded applications through
            // 'Double checked locking' pattern which (once
            // the instance exists) avoids locking each
            // time the method is invoked
            if (_instance == null)
            {
                lock (syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new LoadBalancer();
                    }
                }
            }

            return _instance;
        }
    }
}