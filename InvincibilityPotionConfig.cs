using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace InvincibilityPotion
{
    public class InvincibilityPotionConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [DefaultValue(60)]
        [ReloadRequired]
        public int InvinciblePotionDurationSeconds;
    }
}
