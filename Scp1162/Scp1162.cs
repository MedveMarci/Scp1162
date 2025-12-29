using System;
using LabApi.Events.CustomHandlers;
using LabApi.Features;
using LabApi.Loader.Features.Plugins;

namespace SCP1162;

public class Scp1162 : Plugin<Config>
{
    public static Scp1162 Instance;
    public string githubRepo = "MedveMarci/SCP-1162";
    public override string Description => "A mysterious hole that gives random items.";
    public override string Name => "SCP-1162";
    public override string Author => "MedveMarci";
    public override Version Version { get; } = new(1, 3, 0);
    public override Version RequiredApiVersion => new(LabApiProperties.CompiledVersion);
    private EventHandler EventHandler { get; } = new();

    public override void Enable()
    {
        Instance = this;
        CustomHandlersManager.RegisterEventsHandler(EventHandler);
    }


    public override void Disable()
    {
        CustomHandlersManager.RegisterEventsHandler(EventHandler);
        Instance = this;
    }
}