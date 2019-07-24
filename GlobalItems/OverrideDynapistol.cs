using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RoyalTerraria14Content.Items
{
    public class OverrideDynapistol : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if(item.type == ItemID.Dynamite)
            {
                item.ammo = ItemID.Dynamite;
            }

            if (item.type == ItemID.StickyDynamite)
            {
                item.ammo = ItemID.StickyDynamite;
            }

            if (item.type == ItemID.BouncyGrenade)
            {
                item.ammo = ItemID.BouncyGrenade;
            }
        }
    }
}
