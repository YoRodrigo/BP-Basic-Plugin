using BrokeProtocol.API;
using BrokeProtocol.Entities;
using System;

namespace BPLatam.Commands.Chat
{
    public class discordUrl : IScript
    {
        public discordUrl()
        {
            CommandHandler.RegisterCommand("discordUrl", new Action<ShPlayer>(onDiscordUrl), null, "discord"); // bpl.discord
        }

        public void onDiscordUrl(ShPlayer player)
        {
            
            if (string.IsNullOrEmpty(Core.Instance.url)) { // Codicional (Si la string de URL esta vacia o es nula)
                player.svPlayer.SendGameMessage("Este servidor no tiene un enlace."); //Enviar mensaje al jugador
                return; //Detener ejecucion del codigo siguiente al if si se cumple la condicion
            }  
            ChatHandler.SendToAll($"&6[SERVIDOR] &eEl enlace a nuestro discord es: {Core.Instance.url}");  //Enviar mensaje global.
        }
    }
}
