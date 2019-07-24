using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RoyalTerraria14Content.Items
{
    public class DiceCane : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dice Cane");
            Tooltip.SetDefault("'I'm up all night to get lucky'");
        }

        public override void SetDefaults()
        {
            item.damage = 14;
            item.melee = true;
            item.width = 60;
            item.height = 62;
            item.useTime = 24;
            item.useAnimation = 24;
            item.useStyle = 1;
            item.knockBack = 6;
            item.crit = 1;
            item.value = Item.sellPrice(0, 0, 16, 0);
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            if(target.value > 0)
            {
                int coinScore;

                if (crit)
                {
                    coinScore = Main.rand.Next(100);
                }
                else
                {
                    coinScore = Main.rand.Next(10000);
                }

                if (coinScore == 0)
                {
                    Item.NewItem(target.getRect(), ItemID.PlatinumCoin, 1);
                }
                else if(coinScore < 50)
                {
                    Item.NewItem(target.getRect(), ItemID.GoldCoin, 1);
                }
                else if(coinScore < 1000)
                {
                    Item.NewItem(target.getRect(), ItemID.SilverCoin, 1);
                }
                else
                {
                    Item.NewItem(target.getRect(), ItemID.CopperCoin, 1);
                }
            }
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoldBar, 12);
            recipe.AddIngredient(ItemID.LuckyHorseshoe, 1);
            recipe.AddIngredient(ItemID.Ruby, 6);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

            ModRecipe recipe1 = new ModRecipe(mod);
            recipe1.AddIngredient(ItemID.PlatinumBar, 12);
            recipe1.AddIngredient(ItemID.LuckyHorseshoe, 1);
            recipe1.AddIngredient(ItemID.Ruby, 6);
            recipe1.AddTile(TileID.Anvils);
            recipe1.SetResult(this);
            recipe1.AddRecipe();
        }
    }
}
