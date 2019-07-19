using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RoyalTerraria14Content.Items
{
    public class OverrideDynamite : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if(item.type == ItemID.Dynamite)
            {
                item.ammo = ItemID.Dynamite;
            }
        }
    }
}
