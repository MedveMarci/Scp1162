using System;
using CommandSystem;

namespace Scp1162;

[CommandHandler(typeof(RemoteAdminCommandHandler))]
[CommandHandler(typeof(GameConsoleCommandHandler))]
public class Scp1162RespawnCommand : ICommand
{
    public string Command => "scp1162respawn";
    public string[] Aliases { get; } = ["1162respawn"];
    public string Description => "Respawns every SCP-1162.";

    public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
    {
        EventHandler.DestroyScp1162();
        EventHandler.SpawnScp1162();
        response = "SCP-1162 spawn/despawn executed.";
        return true;
    }
}

[CommandHandler(typeof(RemoteAdminCommandHandler))]
[CommandHandler(typeof(GameConsoleCommandHandler))]
public class Scp1162DespawnCommand : ICommand
{
    public string Command => "scp1162despawn";
    public string[] Aliases { get; } = ["1162despawn"];
    public string Description => "Despawns every SCP-1162.";

    public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
    {
        EventHandler.DestroyScp1162();
        response = "SCP-1162 despawn executed.";
        return true;
    }
}

[CommandHandler(typeof(RemoteAdminCommandHandler))]
[CommandHandler(typeof(GameConsoleCommandHandler))]
public class Scp1162SpawnCommand : ICommand
{
    public string Command => "scp1162Spawn";
    public string[] Aliases { get; } = ["1162Spawn"];
    public string Description => "Spawns every SCP-1162.";

    public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
    {
        EventHandler.SpawnScp1162();
        response = "SCP-1162 spawn executed.";
        return true;
    }
}