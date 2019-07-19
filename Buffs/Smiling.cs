using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.ID;
using Microsoft.Xna.Framework.Graphics;

namespace RoyalTerraria14Content.Buffs
{
    public class Smiling : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Smiling");
            Description.SetDefault("Healing over time");
            Main.debuff[Type] = false;
            Main.buffNoSave[Type] = false;
            canBeCleared = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.lifeRegen += 30;
        }

        public override void Update(NPC npc, ref int buffIndex)
        {
            npc.lifeRegen += 30;
        }
    }
}
