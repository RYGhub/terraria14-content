using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RoyalTerraria14Content.Items
{
    public class Fioryg : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fioryg");
            Tooltip.SetDefault("A rare coin from ages past.");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.maxStack = 7;
            item.rare = -11;
            item.questItem = true;
        }
    }
}
