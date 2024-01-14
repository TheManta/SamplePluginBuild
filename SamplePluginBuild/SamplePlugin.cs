using ff14bot.AClasses;
using System;
using System.Reflection;

namespace SamplePluginBuild
{
    public class SamplePlugin : BotPlugin
    {
        public override string Author => "Sample Author Name";

        public override string Name => "Sample Plugin Name";

        public override string Description => "Sample Plugin Description";

        public override Version Version { get; } = Assembly.GetExecutingAssembly().GetName().Version;
    }
}
