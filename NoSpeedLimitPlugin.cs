using BepInEx;
using BepInEx.Unity.IL2CPP;


namespace NoSpeedLimit
{
    [BepInPlugin("poh.bepinex.plugins.nospeedlimit", "No Speed Limit", "1.0.0")]
    public class NoSpeedLimitPlugin : BasePlugin
    {
        public static NoSpeedLimitPlugin? Instance { get; private set; }

        public static float BaseGroundSpeedLimit;
        public static float BaseAirSpeedLimit;

        public override void Load()
        {
            Log.LogInfo($"Plugin No Speed Limit is loaded!");
            AddComponent<NoSpeedLimitComponent>();

            Instance = this;
        }

        public override bool Unload()
        {
            Conf.s.maxGroundSpeed = BaseGroundSpeedLimit;
            Conf.s.maxAirSpeed = BaseAirSpeedLimit;
            Log.LogInfo($"Plugin No Speed Limit unloaded. Speed limits set to default values");

            Instance = null;
            return true;
        }
    }
}
