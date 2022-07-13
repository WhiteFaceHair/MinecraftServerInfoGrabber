using System.Collections.Generic;

namespace MinecraftServerInfoGrabber
{
    /**
     * author: WhiteFaceHair
     * e-mail: whitefacehair@gmail.com
     * 
     * Minecraft Server Info Grabber
     */
    
    public interface IGrabber
    {
        void Update();
        string GetServerMotd();
        string GetServerSoftware();
        string GetServerVersion();
        int GetPlayerCount();
        int GetMaxPlayerCount();
        List<string> GetPlayers();
    }
}