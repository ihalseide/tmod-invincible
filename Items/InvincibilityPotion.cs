using IzakModOne.Buffs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace IzakModOne.Items {
    internal class InvincibilityPotion : ModItem {
        public override void SetDefaults() {
            Item.width = 14;
            Item.height = 24;
            Item.scale = 0.5f;

            Item.maxStack = 30;
            Item.rare = ItemRarityID.Green;

            Item.consumable = true;
            Item.useAnimation = 20;
            Item.useTime = 60;
            Item.useTurn = true;
            Item.UseSound = SoundID.Item3;
            Item.useStyle = ItemUseStyleID.DrinkLong;

            Item.buffType = ModContent.BuffType<Invincibility>();
            Item.buffTime = Item.useTime + 60 * ModContent.GetInstance<IzakModOne>().InvinciblePotionDurationSeconds; // (there are 60 ticks per second)
        }

        public override void AddRecipes() {
            Recipe r = CreateRecipe();
            r.AddIngredient(ItemID.BottledHoney);
            r.AddIngredient(ItemID.FallenStar, 5);
            r.AddIngredient(ItemID.Blinkroot, 1);
            r.AddIngredient(ItemID.Daybloom, 1);
            r.AddIngredient(ItemID.LifeCrystal, 1);
            r.AddIngredient(ItemID.Mushroom, 1);

            r.AddTile(TileID.Bottles);
            r.AddTile(TileID.CookingPots);

            r.Register();
        }
    }
}
