using Terraria;
using Terraria.ModLoader;

namespace RoyalTerraria14Content.Prefixes
{
    public class ViktyaPrefix : ModPrefix
    {
        public override void SetDefaults() => DisplayName.SetDefault("Viktya's");

        public override bool CanRoll(Item item) => true;

        public override float RollChance(Item item) => 0.1f;

        public override PrefixCategory Category => PrefixCategory.Magic;

        public ViktyaPrefix() { }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus)
        {
            manaMult -= 0.44f;
        }

        public override void ModifyValue(ref float valueMult)
        {
            valueMult += 2f;
        }
    }
}