using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace IzakModOne.Buffs {
    internal class Invincibility : ModBuff {

        /**
         * List of buffs to make invincibility be immune to.
         */
        public Int32[] immunities = [
            BuffID.Poisoned,
            BuffID.OnFire,
            BuffID.OnFire3,
            BuffID.Bleeding,
            BuffID.Suffocation,
            BuffID.Darkness,
            BuffID.Confused,
            BuffID.Slow,
            BuffID.Slimed,
            BuffID.Silenced,
            BuffID.Starving,
            BuffID.Stinky,
            BuffID.Weak,
            BuffID.BrokenArmor,
            BuffID.Frostburn,
            BuffID.Frostburn2,
            BuffID.Ichor,
            BuffID.Chilled,
            BuffID.Cursed,
        ];

        public override void SetStaticDefaults() {
            Main.debuff[Type] = false;
            Main.buffNoTimeDisplay[Type] = false;
        }
        public override void Update(Player player, ref int buffIndex) {
            GlobalPlayer thePlayer = player.GetModPlayer<GlobalPlayer>();
            thePlayer.hasInvincibility = true;

            for (int i = 0; i < immunities.Length; i++) {
                thePlayer.Player.buffImmune[immunities[i]] = true;
            }
        }
    }
}
