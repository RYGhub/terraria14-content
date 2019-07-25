using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RoyalTerraria14Content.Items
{
    public class BlueSwede : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blue Swede");
            Tooltip.SetDefault("Stickyfies dynamite");
        }

        public override void SetDefaults()
        {
            item.width = 78;
            item.height = 44;

            item.thrown = true;
            item.damage = 250;
            item.knockBack = 0;
            item.crit = 0;

            item.autoReuse = true;

            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 5;
            item.noMelee = true;

            item.value = Item.sellPrice(0, 12, 77, 77);
            item.rare = 8;

            item.UseSound = SoundID.Item11;

            item.shoot = ProjectileID.StickyDynamite;
            item.shootSpeed = 10f;
            item.useAmmo = ItemID.StickyDynamite;

            item.scale = 0.7f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem<Dynapistol>(), 1);
            recipe.AddIngredient(ItemID.GoldBar, 6);
            recipe.AddIngredient(ItemID.ShroomiteBar, 18);
            recipe.AddIngredient(ItemID.Gel, 99);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
