using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RoyalTerraria14Content.Items
{
    public class BaneOfKrushGull : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bane of Krush Gull");
            Tooltip.SetDefault("The floating sword of the Royal Terror");
        }

        public override void SetDefaults()
        {
            item.damage = 120;
            item.melee = true;
            item.width = 130;
            item.height = 130;
            item.useTime = 60;
            item.useAnimation = 60;
            item.useStyle = 1;
            item.knockBack = 20;
            item.value = Item.sellPrice(0, 8, 0, 0);
            item.rare = 5;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;

        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.NextBool(3))
            {
                Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.Blood);
            }
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.Bleeding, 300);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FleshBlock, 666);
            recipe.AddIngredient(ItemID.CrimtaneBar, 66);
            recipe.AddIngredient(ItemID.TissueSample, 66);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
