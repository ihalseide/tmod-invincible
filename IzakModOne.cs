using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace IzakModOne {
    public class IzakModOne : ModConfig {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [DefaultValue(30)]
        [ReloadRequired]
        public int InvinciblePotionDurationSeconds;
    }
}