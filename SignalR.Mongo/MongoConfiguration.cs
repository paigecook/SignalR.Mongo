﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SignalR.Mongo
{
    public class MongoConfiguration
    {
        private const long DEFAULT_COLLECTION_SIZE = 1073741824; //1GB in bytes
        public string Server { get; set; }
        public int Port { get; set; }
        public string Database { get; set; }
        public string Collection { get; set; }
        public bool AllowSlaveReads { get; set; }
        public long CollectionSize { get; set; }


        public MongoConfiguration()
        {
            LoadDefaults();
        }
        public MongoConfiguration(string server, int port, string database, string collection)
        {
            LoadDefaults();
            Server = server;
            Port = port;
            Database = database;
            Collection = collection;
        }


        private void LoadDefaults()
        {
            Port = 27017;
            AllowSlaveReads = false;
            CollectionSize = DEFAULT_COLLECTION_SIZE;
        }

    }
}
