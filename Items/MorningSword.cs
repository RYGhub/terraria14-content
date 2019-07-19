using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RoyalTerraria14Content.Items
{
    public class MorningSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Morning Sword");
            Tooltip.SetDefault("It actually is a spear");
        }

        public override void SetDefaults()
        {
            item.width = 100;
            item.height = 100;

            item.melee = true;
            item.damage = 26;
            item.knockBack = 6.5f;
            item.crit = 4;

            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 1;

            item.value = Item.sellPrice(0, 1, 50, 0);
            item.rare = 2;

            item.UseSound = SoundID.Item1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe1 = new ModRecipe(mod);
            recipe1.AddIngredient(ItemID.Spear);
            recipe1.AddIngredient(ItemID.IronShortsword);
            recipe1.AddIngredient(ItemID.BallOHurt);
            recipe1.AddTile(TileID.Anvils);
            recipe1.SetResult(this);
            recipe1.AddRecipe();

            ModRecipe recipe2 = new ModRecipe(mod);
            recipe2.AddIngredient(ItemID.Spear);
            recipe2.AddIngredient(ItemID.LeadShortsword);
            recipe2.AddIngredient(ItemID.BallOHurt);
            recipe2.AddTile(TileID.Anvils);
            recipe2.SetResult(this);
            recipe2.AddRecipe();

            ModRecipe recipe3 = new ModRecipe(mod);
            recipe3.AddIngredient(ItemID.Spear);
            recipe3.AddIngredient(ItemID.IronShortsword);
            recipe3.AddIngredient(ItemID.TheMeatball);
            recipe3.AddTile(TileID.Anvils);
            recipe3.SetResult(this);
            recipe3.AddRecipe();

            ModRecipe recipe4 = new ModRecipe(mod);
            recipe4.AddIngredient(ItemID.Spear);
            recipe4.AddIngredient(ItemID.LeadShortsword);
            recipe4.AddIngredient(ItemID.TheMeatball);
            recipe4.AddTile(TileID.Anvils);
            recipe4.SetResult(this);
            recipe4.AddRecipe();
        }
    }
}
