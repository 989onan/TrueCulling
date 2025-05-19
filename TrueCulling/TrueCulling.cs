using HarmonyLib;
using ResoniteModLoader;

namespace TrueCulling
{
    public class TrueCulling : ResoniteMod
    {
        public override string Author => "989onan";
        public override string Link => "Nope";
        public override string Name => "True Culling";
        public override string Version => "1.0.0";

        public override void OnEngineInit()
        {
            Harmony harmony = new Harmony($"{Author}.{Name}");
            harmony.PatchAll();
        }

        
    }
}