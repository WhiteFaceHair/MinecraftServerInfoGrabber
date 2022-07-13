using System;
using System.Collections.Generic;
using MinecraftServerInfoGrabber.utils;
using Newtonsoft.Json.Linq;

namespace MinecraftServerInfoGrabber.grabber
{
    /**
     * author: WhiteFaceHair
     * e-mail: whitefacehair@gmail.com
     * 
     * Minecraft Server Info Grabber
     */
    
    public class Mcsrvstat : ServerInfo, IGrabber
    {
        private static readonly string BASE_URL = "https://api.mcsrvstat.us/2/";
        
        private string _serverUrl;

        public Mcsrvstat(string address, int port) : base(address, port)
        {
            this._serverUrl = BASE_URL + address;
            this.Update();
        }

        public void Update()
        {
            this.UpdateDatabase(this._serverUrl);
        }

        public string GetServerMotd()
        {
            var motdMap = JObjectConverter.GetDictionary(this.Get("motd"));
            var rawInfo = (JArray) motdMap["clean"];
            
            return (string) rawInfo[0];
        }

        public string GetServerSoftware()
        {
            return (string) this.Get("software");
        }

        public string GetServerVersion()
        {
            return (string) this.Get("version");
        }

        public int GetPlayerCount()
        {
            var playersInfoMap = JObjectConverter.GetDictionary(this.Get("players"));
            
            return int.Parse(playersInfoMap["online"].ToString());
        }

        public int GetMaxPlayerCount()
        {
            var playersInfoMap = JObjectConverter.GetDictionary(this.Get("players"));
            
            return int.Parse(playersInfoMap["max"].ToString());
        }

        public List<string> GetPlayers()
        {
            var playersInfoMap = JObjectConverter.GetDictionary(this.Get("players"));
            var playersNameArray = (JArray) playersInfoMap["list"];

            var playersNameList = new List<string>();
            foreach (var pName in playersNameArray)
            {
                playersNameList.Add((string)pName);
            }

            return playersNameList;
        }

        public Dictionary<string, string> GetPlayersWithUuid()
        {
            try
            {
                var playersInfoMap = JObjectConverter.GetDictionary(this.Get("players"));
                var playersNameArray = (JArray) playersInfoMap["list"];
                var playersUuidMap = JObjectConverter.GetDictionary(playersInfoMap["uuid"]);

                var result = new Dictionary<string, string>();
                foreach (string pName in playersNameArray)
                {
                    result[pName] = (string) playersUuidMap[pName];
                }

                return result;
            }
            catch (Exception e)
            {
                var invalidResult = new Dictionary<string, string>();
                invalidResult[INVALID_STR] = INVALID_STR;

                return invalidResult;
            }
        }

        public new bool IsServerRunning()
        {
            if ((string) this.Get("ip") != "127.0.0.1" && (string) this.Get("ip") != INVALID_STR)
            {
                return true;
            }

            return false;
        }
    }
}