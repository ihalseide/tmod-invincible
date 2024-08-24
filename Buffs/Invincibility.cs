using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace InvincibilityPotion.Buffs
{
    internal class Invincibility : ModBuff
    {

        // List of debuffs that Invincibility will make the player immune to (should be almost all of them).
        public Int32[] immuninties = [
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

        public override void SetStaticDefaults()
        {
            Main.debuff[Type] = false;
            Main.buffNoTimeDisplay[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            GlobalPlayer thePlayer = player.GetModPlayer<GlobalPlayer>();

            // This effect sets the flag for having invincibility
            thePlayer.hasInvincibility = true;

            for (int i = 0; i < immuninties.Length; i++)
            {
                thePlayer.Player.buffImmune[immuninties[i]] = true;
            }
        }
    }
}
