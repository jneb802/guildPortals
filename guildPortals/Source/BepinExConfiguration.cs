using BepInEx.Configuration;

namespace guildPortals
{
    public class BepinExConfiguration
    {
        private static BepinExConfiguration _instance;
        public static BepinExConfiguration Instance => _instance ??= new BepinExConfiguration();

        public ConfigFile Config { get; set; }

        private BepinExConfiguration()
        {
        }
    }
} 