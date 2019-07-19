using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.ID;
using Microsoft.Xna.Framework.Graphics;

namespace RoyalTerraria14Content.Buffs
{
    public class Ultrapoisoned : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Ultrapoisoned");
            Description.SetDefault("Taking a lot of damage");
            Main.debuff[Type] = true;
            Main.buffNoSave[Type] = false;
            canBeCleared = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.lifeRegen -= 100;
        }

        public override void Update(NPC npc, ref int buffIndex)
        {
            npc.lifeRegen -= 100;
        }
    }
}
