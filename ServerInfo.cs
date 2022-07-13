using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;

namespace MinecraftServerInfoGrabber
{
    /**
     * author: WhiteFaceHair
     * e-mail: whitefacehair@gmail.com
     * 
     * Minecraft Server Info Grabber
     */
    
    public class ServerInfo
    {
        public static readonly string INVALID_STR = "*invalid*";
        
        public string Address { get; }
        public int Port { get; }
        private bool _isOnline;
        private Dictionary<string, object> _database;

        protected ServerInfo(string address, int port)
        {
            this.Address = address;
            this.Port = port;
        }

        protected void UpdateDatabase(string apiAddress)
        {
            try
            {
                var jsonString = new WebClient().DownloadString(apiAddress);
                this._database = JsonConvert.DeserializeObject<Dictionary<string, object>>(jsonString);
                this._isOnline = true;
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message);
                this._isOnline = false;
            }
        }

        protected object Get(string key)
        {
            if (this._database.ContainsKey(key))
            {
                return this._database[key];
            }

            return INVALID_STR;
        }

        public bool IsServerRunning()
        {
            return this._isOnline;
        }
    }
}