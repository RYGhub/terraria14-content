using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RoyalTerraria14Content.Items
{
    public class Pinkzi : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pinkzi");
            Tooltip.SetDefault("Shoots bouncy grenades");
        }

        public override void SetDefaults()
        {
            item.width = 96;
            item.height = 64;

            item.thrown = true;
            item.damage = 120;
            item.knockBack = 0;
            item.crit = 0;

            item.autoReuse = true;

            item.useTime = 9;
            item.useAnimation = 9;
            item.useStyle = 5;
            item.noMelee = true;

            item.value = Item.sellPrice(0, 5, 45, 0);
            item.rare = 7;

            item.UseSound = SoundID.Item11;

            item.shoot = ProjectileID.BouncyGrenade;
            item.shootSpeed = 6f;
            item.useAmmo = ItemID.BouncyGrenade;

            item.scale = 0.7f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Uzi);
            recipe.AddIngredient(ItemID.OrichalcumBar, 18);
            recipe.AddIngredient(ItemID.IllegalGunParts, 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override Vector2? HoldoutOrigin()
        {
            return new Vector2(-32, -10);
        }
    }
}
