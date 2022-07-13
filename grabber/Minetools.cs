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
    
    public class Minetools : ServerInfo, IGrabber
    {
        private static readonly string BASE_URL = "https://api.minetools.eu/ping/";
        
        private string _serverUrl;

        public Minetools(string address, int port) : base(address, port)
        {
            this._serverUrl = BASE_URL + address + "/" + port;
            this.Update();
        }

        public void Update()
        {
            this.UpdateDatabase(this._serverUrl);
        }

        public string GetServerMotd()
        {
            return (string) this.Get("description");
        }
        
        public string GetServerSoftware()
        {
            return INVALID_STR; // doesn't support
        }

        public string GetServerVersion()
        {
            var versionMap = JObjectConverter.GetDictionary(this.Get("version"));

            return (string) versionMap["name"];
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
            var playersSampleArray = (JArray) playersInfoMap["sample"];

            var playersNameList = new List<string>();
            foreach (var pInfo in playersSampleArray)
            {
                var pInfoMap = JObjectConverter.GetDictionary(pInfo);
                playersNameList.Add((string) pInfo["name"]);
            }

            return playersNameList;
        }

        public Dictionary<string, string> GetPlayersWithUuid()
        {
            var playersInfoMap = JObjectConverter.GetDictionary(this.Get("players"));
            var playersSampleArray = (JArray) playersInfoMap["sample"];

            var result = new Dictionary<string, string>();
            foreach (var pInfo in playersSampleArray)
            {
                var pInfoMap = JObjectConverter.GetDictionary(pInfo);
                result.Add((string) pInfoMap["name"], (string) pInfoMap["id"]);
            }

            return result;
        }

        public new bool IsServerRunning()
        {
            if ((string) this.Get("error") == INVALID_STR)
            {
                return true;
            }

            return false;
        }
    }
}