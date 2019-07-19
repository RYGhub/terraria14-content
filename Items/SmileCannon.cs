using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RoyalTerraria14Content.Items
{
    public class SmileCannon : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Smile Cannon");
            Tooltip.SetDefault("Make your friends smile and heal them");
        }

        public override void SetDefaults()
        {
            item.damage = 20;
            item.knockBack = 0;
            item.crit = 0;
            item.mana = 6;
            item.width = 80;
            item.height = 48;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 5;
            item.noMelee = true;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 3;
            item.UseSound = SoundID.Item20;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType<Projectiles.Smile>();
            item.shootSpeed = 4f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe1 = new ModRecipe(mod);
            recipe1.AddIngredient(ItemID.KOCannon);
            recipe1.AddIngredient(ItemID.Sunflower, 30);
            recipe1.AddTile(TileID.MythrilAnvil);
            recipe1.SetResult(this);
            recipe1.AddRecipe();
        }
    }
}
