using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RoyalTerraria14Content.Items
{
    public class Dynapistol : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dynapistol");
            Tooltip.SetDefault("Shoots lit dynamite");
        }

        public override void SetDefaults()
        {
            item.width = 78;
            item.height = 44;

            item.ranged = true;
            item.damage = 250;
            item.knockBack = 0;
            item.crit = 0;

            item.autoReuse = true;

            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 5;
            item.noMelee = true;

            item.value = Item.sellPrice(0, 6, 0, 0);
            item.rare = 2;

            item.UseSound = SoundID.Item11;

            item.shoot = ProjectileID.Dynamite;
            item.shootSpeed = 8f;
            item.useAmmo = ItemID.Dynamite;

            item.scale = 0.7f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FlintlockPistol);
            recipe.AddIngredient(ItemID.IllegalGunParts);
            recipe.AddIngredient(ItemID.Wood, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
