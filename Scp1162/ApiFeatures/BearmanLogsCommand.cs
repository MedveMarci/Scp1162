using System;
using CommandSystem;

namespace Scp1162.ApiFeatures;

[CommandHandler(typeof(GameConsoleCommandHandler))]
public class BearmanLogs1162 : ICommand
{
    public string Command => "bearmanlogs1162";

    public string[] Aliases { get; } = ["bmlogs1162"];

    public string Description => "Sends collected plugin logs to the log server and returns the log id.";

    public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
    {
        var getLogHistory = LogManager.GetLogHistory();
        response = getLogHistory.logResult;
        return getLogHistory.success;
    }
}