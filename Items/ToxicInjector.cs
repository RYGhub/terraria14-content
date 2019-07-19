using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RoyalTerraria14Content.Items
{
    public class ToxicInjector : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Toxic Injector");
            Tooltip.SetDefault("Ultrapoisons enemies");
        }

        public override void SetDefaults()
        {
            item.width = 100;
            item.height = 100;

            item.melee = true;
            item.damage = 35;
            item.knockBack = 4.5f;
            item.crit = 1;

            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 5;

            item.value = 0;
            item.rare = 4;

            item.noMelee = true;
            item.noUseGraphic = true;

            item.UseSound = SoundID.Item1;

            item.shootSpeed = 4f;
            item.shoot = mod.ProjectileType<Projectiles.ToxicInjector>();
        }

        public override bool CanUseItem(Player player)
        {
            return player.ownedProjectileCounts[item.shoot] < 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe1 = new ModRecipe(mod);
            recipe1.AddIngredient(ItemID.CobaltNaginata);
            recipe1.AddIngredient(ItemID.JungleSpores, 25);
            recipe1.AddIngredient(ItemID.Vine, 25);
            recipe1.AddTile(TileID.Anvils);
            recipe1.SetResult(this);
            recipe1.AddRecipe();

            ModRecipe recipe2 = new ModRecipe(mod);
            recipe2.AddIngredient(ItemID.PalladiumPike);
            recipe2.AddIngredient(ItemID.JungleSpores, 25);
            recipe2.AddIngredient(ItemID.Vine, 25);
            recipe2.AddTile(TileID.MythrilAnvil);
            recipe2.SetResult(this);
            recipe2.AddRecipe();
        }
    }
}
