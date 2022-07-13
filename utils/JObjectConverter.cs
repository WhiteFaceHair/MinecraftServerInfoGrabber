using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace MinecraftServerInfoGrabber.utils
{
    /**
     * author: WhiteFaceHair
     * e-mail: whitefacehair@gmail.com
     *
     * Minecraft Server Info Grabber
     */
    
    public static class JObjectConverter
    {
        public static Dictionary<string, object> GetDictionary(object o)
        {
            return JObject.FromObject(o).ToObject<Dictionary<string, object>>();
        }
    }
}