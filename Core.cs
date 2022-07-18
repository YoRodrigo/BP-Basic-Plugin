using BrokeProtocol.API;
using BrokeProtocol.Managers;

namespace BPLatam
{
    public class Core : Plugin
    {
        public static Core Instance { get; set; } // Instancia (Acceder a las variables dentro del Core)
        public string url = "https://www.haziel.tk/BPBasics"; // Variable url
        public SvManager SvManager { get; set; } // SvManager

        public Core()
        {
            Instance = this; // Seteamos instancia como la instancia donde se ejecuta el plugin.
            Info = new PluginInfo("BPLatam", "bpl") // Informacion del plugin
            {
                Description = "Plugin madre de Latam Server",
                Website = "https://www.haziel.tk"
            };
        }
    }
}
