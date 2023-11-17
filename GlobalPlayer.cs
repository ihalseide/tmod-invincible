using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace IzakModOne {
	public class GlobalPlayer : ModPlayer {
        public bool hasInvincibility;
        public bool hasNoClip;

        public override void ResetEffects() {
            hasInvincibility = false;
            hasNoClip = false;
        }

        public override bool ImmuneTo(PlayerDeathReason damageSource, int cooldownCounter, bool dodgeable) {
            // INVINCIBILITY - immune to everything
            if (Player == Main.LocalPlayer && hasInvincibility) {
                return true;
            }
            else {
                return base.ImmuneTo(damageSource, cooldownCounter, dodgeable);
            }
        }

        public override void PreUpdateBuffs() {
            // INVINCIBILITY - Remove 'Cursed' debuff from player
            if (hasInvincibility) {
                Player.ClearBuff(BuffID.Cursed);
            }
        }
    }
}
